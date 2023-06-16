# C\# Syntax

- Understanding The Essential C# Building Blocks
- Working with built-in types
- C# Operators
- Using date and time
- Converting between types
- Implicit Typing

## Understanding The C# Building Blocks

### C\# Statements

- executed in a defined order, standard is vertically
- always end with a semicolon
- curly braces surround statements
- line breaks and white space are ignored by compiler

### C\# Identifiers

- names assigned to lines to be able to find them
- can include letters, numbers or underscores
- the first letter must be a letter or underscore

### C\# Comments

- double slash denotes a comment // ....
- multiline comments can be denoted with /*...*/

### C\# Keywords

- reserved words that have a special meaning
- cannot be used as identifier
- can comment using ctrl + k + c
- can uncomment using ctrl + k + u

### C\# Variables

- variables are storage locations that hold a value
- must be named uniquely for each context it is used
- can be "typed" (int, string, date, ect)
- the type defines what kind of value it can hold
- created in a declaration statement
  - int age = 25;
  - type name = value
- C# is case sensitive, a variable with lower and uppercase names would be treated differently
- variables are named with a lower case
- variables are named in camelCase

### Working with Built-In Types

- every variable has a type
- used to store information
- expressions will return a value of a specified type
- types determine where and the size set aside for the data

### Data Types in C\#

- there are two types
  - predefined types
  - user defined types
- Predefined Types
  - bool
  - int
    - int a = 2;
    - int b = a + 3
    - type = expression
  - float
  - double
  - decimal
  - char
  - string

### Using a Const Value

- using const prefix stops a value from being changed

### Understanding Strings

- contain text
- behave a bit differently that most data types
- consist of a series of characters
- string.Empty creates an empty string

## C\# Operators

- operators are often use in expressions on the right side of variable
- 4 broad types
  - arithmetic
  - equality
  - logical
  - assignment

### Arithmetic Operators

- \+ for addition
- \- for subtraction
- \* multiplication
- \/ for division
- \++ for incrementing a value by one
- \- for incrementing a value by one
- many can be use in a compound fashion
