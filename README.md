# Story Spoiler – QA Automation Project

![Build Status](https://github.com/KristiyanGeorgiev1996/Story-Spoiler/actions/workflows/main.yml/badge.svg)
![Coverage](https://img.shields.io/badge/Coverage-85%25-brightgreen)
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/License-MIT-blue)
![Last Commit](https://img.shields.io/github/last-commit/KristiyanGeorgiev1996/Story-Spoiler)
![QA Automation](https://img.shields.io/badge/QA-Automation-blue)
![C#](https://img.shields.io/badge/Language-C%23-purple)
![.NET](https://img.shields.io/badge/.NET-Framework-512BD4)
![Selenium](https://img.shields.io/badge/Testing-Selenium-green)
![NUnit](https://img.shields.io/badge/Test%20Framework-NUnit-orange)
![GitHub Actions](https://img.shields.io/badge/GitHub-Actions-2088FF)

---

# 📖 Project Overview

**Story Spoiler** is a QA Automation project that demonstrates automated testing practices for a web application which reveals spoilers for stories, movies, and books.  

The project validates key user interactions such as searching for stories and displaying spoiler content. Automated tests ensure the application behaves correctly and consistently.  

Integrated with **GitHub Actions**, the tests run automatically whenever changes are pushed.

---

# 🧪 Assignment Description

**Objective:** Implement automated UI tests to validate functionality of a story spoiler application.  

**Functional Requirements:**
- Search for a story, movie, or book  
- Reveal spoiler information  
- Handle invalid search queries  
- Prevent empty searches  
- Display relevant results for valid queries  

**Testing Goals:** Ensure correct system behavior across multiple scenarios, covering both positive and negative cases.

---

# ⭐ Features

- Automated UI tests using Selenium WebDriver  
- NUnit test framework  
- Page Object Model (POM) structure  
- CI/CD pipeline using GitHub Actions  
- Automated validation on every commit  

---

# 🛠 Technologies Used

| Technology | Description |
|------------|-------------|
| C# | Main programming language |
| .NET | Development framework |
| Selenium WebDriver | UI automation |
| NUnit | Testing framework |
| Git | Version control |
| GitHub | Repository hosting |
| GitHub Actions | CI/CD automation |

---

# 📂 Project Structure

```text
Story-Spoiler
│
├── .github
│   └── workflows
│       └── tests.yml
├── Foody
│   ├── Tests
│   ├── Pages
│   └── Utilities
├── docs
│   ├── testing-strategy.md
│   ├── ci-cd-pipeline.md
│   └── test-cases.md
├── README.md
├── LICENSE
├── .gitignore
└── StorySpoiler.sln
```

---

# 🧾 Test Scenarios

The project currently covers the following testing scenarios:

### Test Case 1 – Search with Valid Input
User enters a valid story name.  
**Expected Result:** The system displays the corresponding spoiler.

### Test Case 2 – Search with Invalid Input
User enters a non-existing story.  
**Expected Result:** The system displays a message indicating that no results were found.

### Test Case 3 – Empty Search
User attempts to search without entering text.  
**Expected Result:** The system prevents the search action and shows a validation message.

### Test Case 4 – Spoiler Visibility
User selects a story result.  
**Expected Result:** The system reveals the spoiler information.

- [Full Test Cases](docs/test-cases.md)

---

# ⚙ CI/CD Pipeline

The project uses GitHub Actions to automatically run tests on **push** or **pull requests** to `main`.  

**Pipeline Steps:**
1. Checkout repository  
2. Install dependencies  
3. Build project  
4. Execute automated tests  
5. Report test results  

- [CI/CD Pipeline Details](docs/ci-cd-pipeline.md)

---

# ▶ Running the Project Locally

1. Clone the repository:
```bash
git clone https://github.com/KristiyanGeorgiev1996/Story-Spoiler.git
```

2. Open the solution in Visual Studio:  
   `StorySpoiler.sln`

3. Restore dependencies (NuGet packages)

4. Run tests using Visual Studio Test Explorer, NUnit Runner, or command line:
```bash
dotnet test StorySpoiler.Tests/StorySpoiler.Tests.csproj
```

---

# 🚀 Future Improvements

- Add more automated test scenarios
- Parallel test execution
- Integration with test reporting tools (Allure, ReportPortal)
- Enhanced CI/CD pipeline
- Test data management improvements

---

# 📚 Learning Purpose

This project demonstrates QA Automation concepts:

- UI Test Automation
- Test Framework Design
- Continuous Integration / Continuous Deployment
- Software Quality Assurance best practices

---

# 👨‍💻 Author

Kristiyan Georgiev – QA Automation Enthusiast

