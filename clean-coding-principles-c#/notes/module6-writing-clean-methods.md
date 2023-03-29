# Writing Clean Methods

## Intro

- High signal functions
- When to create a function
- Techniques to maintain simplicity
- Approaches to minimize variable lifetime
- Signs function is too long
- Exceptions and error handling

## Function vs Method

- both are pieces of code, called by name
- used interchangeably in this chapter
- CORE DIFFERENCE
  - Methods are associated with an Object

## When to create a function

- functions organize code into small targeted pieces of logic (like paragraphs

### 4 common reasons

- duplication - honors CLEAN principle
- Indentation - sign of complexity
- Unclear Intent - Provide high level summaries
- Greater than 1 task - do one thing and do one thing well

- Only catch an exception you can handle immediately
- if you cant handle the application is broken
- the correct response for a broken application is too crash
- A broken app that does not crash is a danger to its self, its data, and its users
- if the system cannot reliable and logically move on. STOP PROCESSING

### Duplication

- Minimize lines and location to maintain
- look for patterns in code as sign of duplication

### Indentation

- Arrow shape code implies complexity
- Hinders readability , testing, increased bug risk
- Comprehension decreases beyond 3 levels of if statements

#### Extract Method

- increases readability
- Allows code to be easily skipped if not required for task
- many small methods allow reader to read at their required level of abstraction

#### Fail Fast

- Throw exception as soon as its applied, call a guard clause
- also useful for switch statements
- early errors help debugging
- note unexpected value in error message

#### Unclear Intent

- layers of abstraction help speed read code
- functions should do 1 thing
- small simple functions are readable, reuseable, easy to name and avoid unwanted side affects

### Mayfly Variables

- listing variables at start of method can lead to confusion
- too much info without context does not help the user
- initialize variables just in time, right before they are used
- declare as late as possible and get them out as soon as possible

### How Many Parameters

- high number of them makes functions hard to understand, sign its doing to much
- strive for 0-2 parameters per function
- separate concerns in separate functions

### Signs Its Too Long

- use of white space and comments
- scrolling required, should fit on one screen
- Naming issues, if its hard to name too much going on
- Multiple conditionals
- Hard to digest

### Exception Types

#### Unrecoverable

- Null Reference, File not found, Access Denied, ect
- show up when app can't move forward in current state

#### Recoverable

- Retry Connection, Try Different File, Wait and Try Again
- Errors that can be caused be a temporary failure
- Should consider giving up on retrys so application isn't in an infinite loop

#### Ignorable

- Logging Clicks
- Very rare circumstance
- Some errors can be ignored if you are completely clear on the implications
- must think through the down stream impacts

### Try/Catch Body Standalone

- Consider moving the try portion to a function
- makes it clear to the reader exactly what is being attempted in the block

## Summery

- When to create a function
  - duplication, indentation, unclear intent, multiple tasks
- Eliminate indentation
  - Extract method, fail fast, return early
  - limit variable lifetime (Mayfly variables)
- Avoid boolean arguments
- Watch for signs function is too long
- Avoid catching unrecoverable exceptions
