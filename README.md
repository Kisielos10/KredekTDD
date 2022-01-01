
# TDD Training
## Overview

This training is an introduction to TDD that I made for my university science club.
We will learn how to use some tools and techniques
for testing applications before coding practial exercises.

## Content
### Test Automation Fundamentals

1. What is a test?
2. Tools for Test Automation
   1. MsTest
   2. nUnit
   3. xUNit

- Goals:
  - Know the difference between test and production code
  - Know how to make a test
  - Know some tools for automated testing

### TDD Fundamentals
1. Motivation
2. TDD Benefits
3. Rules and TDD cycle
4. What makes a test good
5. Resources for further doubts
6. Apply TDD on exercises

- Goals:
  - Knowing the theory behind TDD
  - Knowing the benefits of TDD
  - Know how to apply TDD on a green field project
  - Know where to look for doubts about TDD

### Isolate System Under Test
1. Motivation: Why do we want to isolate code?
2. Test-doubles:
   1. Stubs
   2. Mocks
   3. Fakes
3. Mocking tools
   1. Rhino
   2. Moq
4. Using dependency injection for isolating

- Exercises:
  - Stubs
  - Mocks

- Goals:
    - Knowing tools for code isolation
    - Apply dependency injection for code isolation
    - Using test-doubles


  ### Bibliography
  - Test-Driven Development by Example. Kent Beck (Learn how to do proper TDD)
  - The art of Unit testing. Roy Oshevore -> (Check the first edition to understand how some tests were created with RhinoMock in Unit4. Check the second edition to improve your knowledge)
  - Unit testing Principles, Practices and Patterns. Vladimir Khorikov  (Really good book to settle down concepts and learn good practices)
  - [You are naming your test wrong](https://enterprisecraftsmanship.com/posts/you-naming-tests-wrong/)
  - [Tests priority](https://blog.cleancoder.com/uncle-bob/2013/05/27/TheTransformationPriorityPremise.html)
  - [Mocks are'nt stubs](https://martinfowler.com/articles/mocksArentStubs.html) (Learn the difference between mocks, stubs, etc...)
  - [The transformation priority Promise](https://blog.cleancoder.com/uncle-bob/2013/05/27/TheTransformationPriorityPremise.html) (Select an order for your tests)