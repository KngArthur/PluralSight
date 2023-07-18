# Adding Decision and Iteration Statements in C\#

- used when parts of code need to be skipped or repeated
- learn about if while and or
- working with boolean values
- making decisions with the if statements
- using the switch statement
- add iterations

## Working with Boolean Values

- they are true or false statements
- bool type
- boolean operators

### Using a Boolean Value

- can use relational operators in bool statements
    - == (equal)
    - != (not equal)
    - > or < (greater or less than)
    - >= or <= (greater or less or equal)

### Using Boolean Logical Operators

- && used if you want true to be returned if both statements return true
- || used if you want true to be returned if either return true

### Making Decisions With the If Statement

- Used when the program flow is not sequential, or needs input
- More often than not used a lot

### Structure of If Statement

- is at its base a boolean expression
- executes if or else based on the true false
- else is optional to use
- multiple condition checks use else if

## Using the Switch Statement

- a way of handling may elif statements
- much cleaner and readable than many elif
- switch uses case with break and default
- the switch runs through all case statements and then the default
- works for most primitive types but not float and double
- each case much be unique
- runs top to bottom
- default does not have to be at bottom
- case statements can be combined to have the same output

## Adding Iterations

### When do we use Itterations

- used to continue executing a task (looping)
- ask for input until stop is reached
- keep reading files from disk

### Loop Options in C\#

#### While

    - pass in a bool expression
    - executes while the bool is true
    - condition is tested before loop runs
    - is only tested again after it runs
    - very easy to create infinate loops
    - loops can be nested as much as we want
#### do-while

- 

#### for

-