# Conditionals That Convey Intent

- we want to clearly convey intent
- make it clear why we would choose
- implicitly written code is shorter and faster
- reads like a sentence
- broken code sounds weird when read aloud

## Be Positive

- use positive conditionals
- negative conditionals increase noise and confusion
- negative indicates you are "coding by accident" rather than intent

## Ternary is Beautiful

- ternary is " : "
- very terse syntax
- honours the dry principle
- reduces lines and repeated method names
- avoid nesting ternary

## YAGNI

- You Ain't Gunna Need It
- add complexity only when needed to clarify intent

## Be Strongly Typed Not Stringly Typed

- instead of calling strings use "dot" typed classes
  - (emptype = "manager") = Bad
  - (emptype = EmployeeType.Manager) = Good
- no risk of typos
- enables use of intellisense
- searchable as a class
- document states

## Magic Numbers

- don't use hard coded "magic" numbers
- provide no content for the value or significance
- use and assigned constant instead
- enumms are also a preferred alternative
- more clearly indicates intent

## Complex Conditionals

- can grow out of hand with use
  - too many combined functions
  - unclear intent due too mixed use
- solutions
  - use of intermediate variables
  - encapsulation via functions

## Intermediate Variables

- can clarify intent by titling the conditionals
- intermediate variables bread up function and clarify actions

## Encapsulation Via Functions

- method names should clarify intent
- names can remove need for comments
- same goes for variable names
- layers of abstraction help maintenance "speed read" code
- methods can be an organizational device

## Proper Polymorphism over Switch

- each class knows how to handle itself
  - no redundant switches needed
- pattern helps us manage activity

## Be Declarative

- tools like link to object can be much cleaner
- declarative nature helps avoid bugs

## Table Driven Methods

- many hard codded elif statements can be replaced with database tables
- makes apps ultra flexible and short
- sometimes helpful to think of logic as "lookup data"

## Summery

- strive for clean intent
- assign and compare booleans implicitly
- prefer positive conditionals
- prefer ternaries over if/else
- be strongly typed via constants and enums
- avoid magic numbers
- avoid complex conditionals
  - declare variables
  - extract methods
- consider DB use often
