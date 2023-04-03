# Writing Clean Methods

- high signal functions
- when to create a function
- techniques to maintain simplicity
- approaches to minimize variable lifetime
- signs function is too long
- exceptions and error handling

## Function vs Method

- both are pieces of code, called by name
- in this chapter referred to interchangeably
- core difference is that methods are associated with an object

## When to Create a Function

- functions organize code into small targeted pieces of logic
    - help to organize code like paragraphs do in writing

### 4 Reasons Too

- Duplication
    - honors the clean principle
- Indentation
    - sign of complexity
- Unclear Intent
    - provide high level summaries of function
- > 1 Task
    - do one thing and one thing well

### Duplication

- minimize line and locations of code to maintain
- look for patterns in code shape and usage
- if used more than once candidate for a method

### Indentation

- Arrow shape code implies complexity
- hinders readability, testing, increased bug risk
- comprehension decreases beyond 3 levels of indentation

#### Indentation solutions

Extract Method

- increases readability
- allows code to be easily skipped if not required to be looked at
- many small methods allow reader to read at chosen level of abstraction

### Fail Fast

- throw exception as soon as its applied
    - called a guard clause
- very useful for switch statements
- early errors help debugging
- note unexpected value in error message

### Unclear Intent

- the layers of abstraction help speed read code
- methods/functions should do 1 thing
- small simple functions are readable and reuseable
- they are easy to name and avoid side affects of poorly named methods

### Mayfly Variables

- concept of initializing a variable just before it is called and used
- helps with reader comprehension as they don't have to memorize several variables initialized at the start of the class
- they do one thing

## How Many Parameters

- a high number makes functions hard to understand, a sign it is doing too much
- strive for 0-2 parameters in a function
- separate concerns should be in separate functions

## Signs it's Too Long

- use of white space and comments
- scrolling required, should fit on one screen
- if its hard to name, it has too much going on
- multiple conditionals
- hard to digest clear purpose
- functions should
    - rarely be over 20 lines
    - rarely be over 3 parameters
- a simple function can be longer with more lines
- a complex function should be shorter with several other methods called inside it

## Exceptions

- only catch exceptions you can handle immediately
- if cannot handle the proper app behavior is too crash
    - example of failing fast and loud
- broken app that doesn't crash is a danger to itself, its data, and its users

### Exception Types

Unrecoverable

- null reference, file not found, Access Denied
- show up when app can't move forward in the current state

Recoverable

- retry connection, try different file, wait and try again
- show up when a temporary issue has stopped the app moving forward
- could be fixed with a second try, refresh, ect
- a cap should be put on retries at a certain point, to stop a possible infinite loop

Ignorable

- logging clicks
- some can be ignored if your completely clear on the implications of doing so
- very rare
- must think through downstream impacts of ignoring exceptions

### Fail Fast

- if the system cannot reliably and logically move on. STOP PROCESSING
- clear function names in try blocks make it easy to identify what is being tested