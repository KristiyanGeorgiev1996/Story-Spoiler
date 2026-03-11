# CI/CD Pipeline – Story Spoiler Project

## Overview

The project uses **GitHub Actions** to implement a **Continuous Integration / Continuous Deployment (CI/CD) pipeline**. This ensures all automated tests run whenever code changes are pushed, maintaining high software quality.

---

## Pipeline Trigger

The workflow is triggered by:

- **Push** to the main branch  
- **Pull requests** to the main branch  

---

## Pipeline Steps

1. **Checkout Repository**  
   The latest code is pulled from GitHub.

2. **Install Dependencies**  
   NuGet packages and required libraries are restored.

3. **Build Project**  
   Compiles the solution and ensures there are no build errors.

4. **Run Automated Tests**  
   Executes NUnit test suite using Selenium WebDriver.

5. **Report Results**  
   Test results are logged and displayed in GitHub Actions.

---

## Benefits

- Ensures **code quality** before merging
- Detects issues **early** in the development cycle
- Enables **continuous feedback** for the team
- Provides **transparent test reporting** for stakeholders

---

## Future Enhancements

- Parallel test execution for faster feedback  
- Integration with test reporting tools (Allure, ReportPortal)  
- Automatic notifications on test failure via email or Slack
