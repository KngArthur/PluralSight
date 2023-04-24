# Refactoring to Clean C Sharp

- refactoring a speaker registration app
- data entered determines if eligible to be a speaker
  - has logic behind scenes that determines eligibility
- initial code make the logic flow hard to see
- Visual Studio helps us analyze our cod equality
  - right click on project, calculate code metrics, displays number metrics
    - maintainability 0-100 score of how easy it is to maintain
    - Cyclomatic Complexity, counts number of paths through the method
    - class coupling, shows how many class' its coupled
    - lines of source code, shows total lines
    - executable code, shows the functioning lines
- tests help document intent, automated tests help us make sure app is functioning without "running the code"

## Refactoring Agenda

1. Remove unhelpful comments
    - to improve signal to noise
2. Refactor to Mayfly variables
    - to reduce info needed to hold in heads
    - when refactoring use find reference then move code just before first use
    - make sure to put it at right level so outer references, ect can reach it
    - has to be in same lexical scope (curly brace level)
3. Use positive conditionals
    - are easier to understand
    - this method has an error shape due to being in multiple elif statements
4. Implement guard clauses
    - to clarify expectation and minimize error handling code
    - new if statements stops invalid data being passed to the method
    - butting the returns of an if statement on next lines, is example
        - this also eliminates arrow code
5. Improve naming
    - to clarify and document intent
6. Return early
    - to reduce the amount of code and improve readability
7. Aggregate related logic
    - help us understand related code sections in isolation
8. Consolidate guard clauses
    - create a higher level abstraction that describes the codes higher level intent
9. Use table-driven method
    - to avoid hard coding logic that is likely to change
10. Fail fast
    - to eliminate indentation and thus cyclomatic complexity

- should make the code much easier to understand and able to speed read.
- write tests first

## Bug Fixes

- the more aggregated methods make it much easier to read through
- the purpose of each method is very clear
- can now look at a particular set of logic in isolation

## Taking it too far

- one line methods are too much

## Staying Clean

When to Refactor

- if it ain't broke don't fix it
- You need to work be working with the code
  - don't change for readers that are not guaranteed to show up
- when you find it difficult to comprehend or change
  - excessive refactoring is questionable when change is small
  - generally size of refactoring should be in line with the code being changed
- Add tests first for regression protection

Code Reviews

- Promote proactive cleanliness
- set guidelines as to what is and isn't off limits
- assure readability and cut off issues down stream
- paired coding
  - real time code review
  - increases quality, cuts down on shortcuts
  - naming and refactoring is easier
