using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Text.Json;

namespace Spoiler
{
    [TestFixture]
    public class SpoilerTests
    {
        private RestClient _client;
        private const string baseUrl = "https://d3s5nxhwblsjbi.cloudfront.net";
        private static string _createdStoryId;

        [OneTimeSetUp]
        public void Setup()
        {
            string token = GetJwtToken("krisko4450", "krisko4450");

            var options = new RestClientOptions(baseUrl)
            {
                Authenticator = new JwtAuthenticator(token)
            };

            _client = new RestClient(options);
        }

        private string GetJwtToken(string username, string password)
        {
            var logInClient = new RestClient(baseUrl);
            var request = new RestRequest("/api/User/Authentication", Method.Post);
            request.AddJsonBody(new { username, password });

            var response = logInClient.Execute(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Login failed: {response.StatusCode} - {response.Content}");
            }

            var json = JsonSerializer.Deserialize<JsonElement>(response.Content);

            if (!json.TryGetProperty("accessToken", out JsonElement tokenElement))
            {
                throw new Exception($"Login response does not contain accessToken: {response.Content}");
            }

            return tokenElement.GetString();
        }

        [Test, Order(1)]
        public void CreateNewStory_ShouldReturnCreatedStory()
        {
            var newStory = new
            {
                title = "My Test Story",
                description = "This is a test description",
                url = "https://example.com/image.jpg"
            };

            var request = new RestRequest("/api/Story/Create", Method.Post);
            request.AddJsonBody(newStory);
            var response = _client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created), "Status code should be 201 Created");

            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response.Content);

            if (jsonResponse.TryGetProperty("storyId", out JsonElement storyIdElement))
            {
                _createdStoryId = storyIdElement.GetString();
                Assert.IsNotEmpty(_createdStoryId, "storyId should not be empty");
            }
            else
            {
                Assert.Fail("Response does not contain 'storyId'");
            }

            if (jsonResponse.TryGetProperty("title", out JsonElement titleElement))
            {
                Assert.AreEqual(newStory.title, titleElement.GetString(), "Title mismatch");
            }

            if (jsonResponse.TryGetProperty("description", out JsonElement descElement))
            {
                Assert.AreEqual(newStory.description, descElement.GetString(), "Description mismatch");
            }

            if (jsonResponse.TryGetProperty("url", out JsonElement urlElement))
            {
                Assert.AreEqual(newStory.url, urlElement.GetString(), "Url mismatch");
            }

            if (jsonResponse.TryGetProperty("message", out JsonElement messageElement))
            {
                Assert.AreEqual("Successfully created!", messageElement.GetString(), "Response message mismatch");
            }
        }


        [Test, Order(2)]
        public void EditStory_ShouldReturnEditedStory()
        {
            if (string.IsNullOrEmpty(_createdStoryId))
            {
                Assert.Fail("No storyId found. Make sure CreateNewStory_ShouldReturnCreatedStory runs first.");
            }

            var updatedStory = new
            {
                title = "Updated Test Story",
                description = "This is an updated test description",
                url = "https://example.com/updated-image.jpg"
            };

            var request = new RestRequest($"/api/Story/Edit/{_createdStoryId}", Method.Put);
            request.AddJsonBody(updatedStory); 

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Status code should be 200 OK");

            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response.Content);
            if (jsonResponse.TryGetProperty("message", out JsonElement messageElement))
            {
                Assert.AreEqual("Successfully updated!", messageElement.GetString(), "Response message mismatch");
            }
        }

        [Test, Order(3)]
        public void GetAllStories_ShouldReturnNonEmptyList()
        {
            var request = new RestRequest("/api/Story/All", Method.Get);
            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Status code should be 200 OK");

            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response.Content);

            Assert.IsTrue(jsonResponse.ValueKind == JsonValueKind.Array, "Response should be an array");
            Assert.IsTrue(jsonResponse.GetArrayLength() > 0, "Story list should not be empty");
        }

        [Test, Order(4)]
        public void DeleteStory_ShouldReturnSuccessMessage()
        {
            if (string.IsNullOrEmpty(_createdStoryId))
            {
                Assert.Fail("No storyId found. Make sure CreateNewStory_ShouldReturnCreatedStory runs first.");
            }

            var request = new RestRequest($"/api/Story/Delete/{_createdStoryId}", Method.Delete);
            var response = _client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "Status code should be 200 OK");

            if (!string.IsNullOrEmpty(response.Content))
            {
                try
                {
                    var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response.Content);
                    if (jsonResponse.TryGetProperty("message", out JsonElement messageElement))
                    {
                        Assert.AreEqual("Deleted successfully!", messageElement.GetString(), "Response message mismatch");
                    }
                }
                catch
                {
                    
                }
            }
        }

        [Test, Order(5)]
        public void CreateStory_WithoutRequiredFields_ShouldReturnBadRequest()
        {
            var incompleteStory = new
            {
                url = "https://example.com/image.jpg"
            };

            var request = new RestRequest("/api/Story/Create", Method.Post);
            request.AddJsonBody(incompleteStory);

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), "Status code should be 400 Bad Request");

            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response.Content);
            if (jsonResponse.TryGetProperty("message", out JsonElement messageElement))
            {
                Assert.IsNotEmpty(messageElement.GetString(), "Error message should not be empty");
            }
        }

        [Test, Order(6)]
        public void EditNonExistingStory_ShouldReturnNotFound()
        {
            string nonExistingStoryId = Guid.NewGuid().ToString();

            var updatedStory = new
            {
                title = "Non-existing Story",
                description = "Trying to edit a story that does not exist",
                url = "https://example.com/nonexistent.jpg"
            };

            var request = new RestRequest($"/api/Story/Edit/{nonExistingStoryId}", Method.Put);
            request.AddJsonBody(updatedStory);

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), "Status code should be 404 Not Found");
            Assert.That(response.Content, Does.Contain("No spoilers"), "Response content should indicate 'No spoilers'");
        }

        [Test, Order(7)]
        public void DeleteNonExistingStory_ShouldReturnBadRequest()
        {
            string nonExistingStoryId = Guid.NewGuid().ToString();

            var request = new RestRequest($"/api/Story/Delete/{nonExistingStoryId}", Method.Delete);

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), "Status code should be 400 Bad Request");
            Assert.That(response.Content, Does.Contain("Unable to delete this story spoiler!"),
                        "Response content should indicate 'Unable to delete this story spoiler!'");
        }


        [OneTimeTearDown]
        public void Cleanup()
        {
            _client?.Dispose();
        }
    }
}
