# Test Cases – Story Spoiler Project

## Test Case 1 – Search with Valid Input
- **Scenario:** Search a valid story
- **Preconditions:** User is on the homepage
- **Steps:**
  1. Enter a valid story name in the search box
  2. Click the Search button
- **Expected Result:** The spoiler content for the story is displayed
- **Priority:** High
- **Notes:** Ensure search is case-insensitive

## Test Case 2 – Search with Invalid Input
- **Scenario:** Search a non-existing story
- **Preconditions:** User is on the homepage
- **Steps:**
  1. Enter invalid story name
  2. Click the Search button
- **Expected Result:** A "No results found" message appears
- **Priority:** Medium
- **Notes:** Test with random strings and symbols

## Test Case 3 – Empty Search
- **Scenario:** Search without input
- **Preconditions:** User is on the homepage
- **Steps:**
  1. Leave search box empty
  2. Click the Search button
- **Expected Result:** Warning message appears and search is not performed
- **Priority:** Medium
- **Notes:** Validation message should be user-friendly

## Test Case 4 – Spoiler Visibility
- **Scenario:** Reveal spoiler content
- **Preconditions:** A search result is available
- **Steps:**
  1. Click on a story from search results
- **Expected Result:** Spoiler content is displayed correctly
- **Priority:** High
- **Notes:** Verify content matches expected spoiler
