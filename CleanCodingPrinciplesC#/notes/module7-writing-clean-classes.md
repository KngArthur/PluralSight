# Writing Clean Classes

Classes are like book headings
when to create a class
measuring quality

- cohesion
- name
- size

primitive obsession
proximity principle
outline rule

## Classis are Like Book Headings

headings/Classes make a book more scannable

- provide a high level summary or que
- Should contain multiple methods with closely related to a single responsibility

## When to Create a Class

new concept

- abstract or real world concepts
- good because they assign concrete names and behaviors to abstract concepts

low cohesion

- Methods should relate
- If methods in class have little to do with each other, they should be split to classes with more targeted responsibilities

Promote Reuse

- if piece of code could be part of larger class but can be used by another part of the program, should be in its own class

Reduce Complexity

- used to hide complex or long methods or hide away properties to increase readability
- Hides the complexity of a "solved problem"
- class groups related operations behind the scenes

Clarify parameters

- wraps up class parameters in something more digestible
- useful to clarify parameters
- simplify information passing
- groups a "lose bag of variables" in something tangible and understandable

## Measuring Quality

Class Responsibilities Should Be Strongly Related

Cohesion

- how strongly the responsibilities of a class are closely related
- highly cohesive classes are more related
- highly readable
- likely to be reused
- Avoid attracting the lazy (Magnet Classes)
- High Cohesion classes have a descriptive name
- Watch for
  - Standalone Methods
    - the methods and properties should work together to achieve use
  - Fields used by only one method
    - should be used by many methods, if not consider extracting to separate class
  - Classes the change often
    - if class receives many more commits than average is a candidate for separate high cohesion classes
- a class can group many different functions under one item eg Vehicle example
  - this class should be split into all the separate concerns of the vehicle, financing, maintenance, general info classes

Single Responsibility Principle

- Each module should do one thing and one thing well.
- should have a single reason to change

Broad Names Lead to Poor cohesion

- classes with broad generic names grow clearly
- The name alone should make it clear its function
- use noun names
- The more concise the name the smaller the classes
- a good measure of cohesion is how many methods use the class' instance variables
  - if many do not, they should be refactored out to another Class

Signs a Class is Too Small

- Rare to complain the a class is too small but they can be
- Inappropriate intimacy
  - if two classes call a large portion of each others methods
- Feature envy
  - if one class relies heavily on each other
- too many pieces
  - overly small classes make it hard to understand how the system works
  - can lead to classes that are tightly bound to each other
- these issues are unicorns in the real world, very rare classes usually overly large

## Primitive Obsession

- can easily slip into passing around loose pieces of data that should be encapsulated in a class
- if a method uses only 1 or 2 properties, consider only passing those only to increase readability and intent

Positives of encapsulating in class

- helps reader conceptualize
- makes the use explicit
- adding a property later helps it still be included in logic
- aids maintenance by grouping all required data in one place

if your passing around a series of related data items, it's time to create a class

## Proximity Principle

- Users read from the top down
- Useful to keep a set of related actions together
- if a method's callee is next it makes it very easy to understand
- if organized in order that it is called it is also helpful
- not always possible but keeping the called methods close is still useful to do when you can

## Outline Rule

- a well written outline has multiple layers, defines from high level to specific points
- classes that utilized the outline rule provide same benefit
- outline rule increases the signal to noise ratio
- in this style some methods may only call a list of child methods, which is fine.
- builds an outline of code that allows the reader to drill down to their desired level of abstraction
- fewer longer methods make the big picture hard to see
