# Testing Strategy – Story Spoiler Project

## Objective

This document outlines the QA testing strategy for the **Story Spoiler** project. The main goal is to ensure the web application behaves correctly under different scenarios using **automated UI tests**.

---

## Testing Approach

The project follows a structured **UI automation strategy** based on best practices:

1. **Test Design**  
   - Use **Page Object Model (POM)** for all UI pages  
   - Separate **test logic** from **UI element selectors**  
   - Keep reusable helper methods in `Utilities`

2. **Test Coverage**  
   - Core user flows:
     - Searching for a story, movie, or book
     - Viewing spoiler content
     - Handling invalid or empty searches
   - Edge cases and input validation

3. **Test Types**  
   - **Positive tests** – valid user actions  
   - **Negative tests** – invalid inputs and empty searches  
   - **UI checks** – visibility of elements, spoilers, buttons

4. **Execution Frequency**  
   - All tests run automatically on **push** and **pull request** events via CI/CD pipeline

---

## Test Organization

| Folder | Description |
|--------|-------------|
| Tests | Contains individual test cases |
| Pages | Page Object Model classes |
| Utilities | Helper methods and reusable code |

---

## QA Principles Applied

- **Atomic tests**: Each test verifies a single functionality  
- **Repeatable**: Tests can run multiple times independently  
- **Maintainable**: Easy to update when UI changes  
- **Reliable**: Flaky tests minimized by proper waits and selectors  

---

## Reporting & Feedback

- Test results are reported in the **CI/CD workflow**  
- Failures are captured with **screenshots and logs**  
- Developers can quickly identify issues and fix them
