# Story Spoiler – QA Automation Project

![QA Automation](https://img.shields.io/badge/QA-Automation-blue)
![Language](https://img.shields.io/badge/Language-C%23-purple)
![Framework](https://img.shields.io/badge/.NET-Framework-512BD4)
![Testing](https://img.shields.io/badge/Testing-Selenium-green)
![Test Framework](https://img.shields.io/badge/Test%20Framework-NUnit-orange)
![CI/CD](https://img.shields.io/badge/CI-CD-black)
![GitHub Actions](https://img.shields.io/badge/GitHub-Actions-2088FF)
[![Build Status](https://img.shields.io/github/actions/workflow/status/KristiyanGeorgiev1996/Story-Spoiler/tests.yml?branch=main)](https://github.com/KristiyanGeorgiev1996/Story-Spoiler/actions/workflows/tests.yml)

---

# 📖 Project Overview

**Story Spoiler** is a QA Automation project created to demonstrate automated testing practices for a web application that reveals spoiler information for stories, movies, and books.

The project focuses on validating key user interactions such as searching for stories and displaying spoiler content. Automated tests ensure that the application behaves correctly and consistently.

The test suite is integrated into a **CI/CD pipeline using GitHub Actions**, which automatically executes the tests whenever changes are pushed to the repository.

This project demonstrates practical skills in:

* UI Test Automation
* Automated Testing Frameworks
* Continuous Integration
* Software Quality Assurance

---

# 🧪 Assignment Description

## Objective

The objective of this assignment is to design and implement an automated testing project that validates the functionality of a web application for searching and displaying story spoilers.

The automated tests should verify the correct behavior of the application when interacting with different types of user input.

---

## Functional Requirements

The application should allow users to:

* search for a story, movie, or book
* reveal spoiler information
* handle invalid search queries
* prevent empty searches
* display relevant results for valid queries

---

## Testing Objectives

The automated tests should verify that:

* the search functionality works correctly
* spoiler information is displayed properly
* invalid inputs are handled correctly
* the system behaves consistently under different scenarios

---

# ⭐ Features

The project includes the following features:

* UI automated tests
* Selenium WebDriver integration
* NUnit testing framework
* automated test execution
* CI/CD pipeline
* GitHub Actions integration
* automated validation on every commit

---

# 🛠 Technologies Used

| Technology         | Description               |
| ------------------ | ------------------------- |
| C#                 | Main programming language |
| .NET               | Development framework     |
| Selenium WebDriver | UI automation framework   |
| NUnit              | Testing framework         |
| Git                | Version control           |
| GitHub             | Repository hosting        |
| GitHub Actions     | CI/CD automation          |

---

# 📂 Project Structure

The project follows a structured layout based on common automation testing practices.

```id="0fny3k"
Story-Spoiler
│
├── .github
│   └── workflows
│       └── tests.yml
│
├── StorySpoiler.Tests
│   ├── Tests
│   ├── Pages
│   └── Utilities
│
├── README.md
└── StorySpoiler.sln
```

### Folder Description

**.github/workflows**

Contains the configuration for the CI/CD pipeline.

**StorySpoiler.Tests**

The main testing project that contains the automated tests.

**Tests**

Contains the actual test scenarios.

**Pages**

Contains Page Object Model classes representing UI elements.

**Utilities**

Helper classes used across the testing project.

---

# 🧾 Test Scenarios

The project currently covers the following testing scenarios.

### Test Case 1 – Search with Valid Input

User enters a valid story name.

Expected Result:

The system displays the corresponding spoiler.

---

### Test Case 2 – Search with Invalid Input

User enters a non-existing story.

Expected Result:

The system displays a message indicating that no results were found.

---

### Test Case 3 – Empty Search

User attempts to search without entering any text.

Expected Result:

The system prevents the search action and shows a validation message.

---

### Test Case 4 – Spoiler Visibility

User selects a story result.

Expected Result:

The system reveals the spoiler information.

---

# ⚙ CI/CD Pipeline

The project uses a **Continuous Integration pipeline** configured with GitHub Actions.

The pipeline automatically runs when:

* code is pushed to the repository
* a pull request is created

### Pipeline Steps

1. Checkout repository
2. Install project dependencies
3. Build the project
4. Execute automated tests
5. Report test results

This ensures that tests are automatically executed whenever changes are made to the codebase.

---

# ▶ Running the Project Locally

To run the tests locally follow these steps.

### 1. Clone the repository

```id="tv9t9b"
git clone https://github.com/your-username/Story-Spoiler.git
```

### 2. Open the solution

Open the solution file in Visual Studio.

```id="0akrtq"
StorySpoiler.sln
```

### 3. Restore dependencies

Visual Studio will automatically restore the required NuGet packages.

### 4. Run the tests

Tests can be executed using:

* Visual Studio Test Explorer
* NUnit Runner
* Command line

---

# 🚀 Future Improvements

The project can be extended with the following improvements:

* additional automated test scenarios
* integration with test reporting tools
* parallel test execution
* Selenium Grid integration
* test data management
* enhanced CI/CD pipeline

---

# 📚 Learning Purpose

This project was created for educational purposes and demonstrates concepts related to:

* QA Automation
* UI Test Automation
* Test Framework Design
* Continuous Integration

---

# 👨‍💻 Author

Kristiyan Georgiev

QA Automation Enthusiast
