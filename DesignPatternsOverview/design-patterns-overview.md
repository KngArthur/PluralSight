# Design Patterns

- what are design patterns
- why spend time learning them
- how to approach this large topic
- some good patterns to start with

- the goal of the course si to understand how design patterns can help you become a better developer and how to learn further

## What is a Design Patterns

- a reusable solution to a common and reoccurring problem
- based on ideas from construction and city planning
- patterns are organized by type;
  - creational
  - organizational
  - structural

## Better Communication

- by using standard patterns it allows team members to more clearly and effectively communicate design intent
- pattern type names can serve as a short hand for design goals

## How to Learn Design Patterns

- Goal is to have a T shaped knowledge of patterns
  - broad understanding of general concepts
  - deep practical understanding of a few design patterns to start

## What Makes a Design Pattern

- pattern definition sections
  - name and classification
  - intent
  - also know as
  - motivation or scenario
    - its application
  - applicability or context
    - where it's used
  - structure
    - how the different parts of the pattern work together
  - participants
  - collaboration
  - consequences
    - the side effects or design tradeoffs
  - implementation
  - sample code
  - known uses
  - related patterns
    - patterns that can be used with this one

### the basics you should have knowledge of

- names
- intent
- motivation and applicability

## Design Pattern Structure

- often described using uml diagrams
  - boxes typically represent classes or interfaces
  - lines represent some kind of relationship like inheritance or interface implementation, or invocation
  - boxes my include details about the classes members, important fields or properties at the top and members at the bottom

### Going Deeper

- structure
  - should be able to recognize a pattern by its unlabeled diagram
- know the participants
- know how to implement in chosen language

## When Should We Apply Design Patterns

### Practice

- usually a good idea to use in a practice
- write tests to verify understanding
- repeat sever-al times with variations
- can use working code in a branch, make sure to delate it

### In Real Code

- follow refactoring fundamentals
- make sure to have good test coverage
- do work in separate branch
- use a pull request after review to merge
- verify behavior is consistent after refactoring
- be prepared to delete code if previous requirements not met, be happy with the experience

## A Few Good Patterns

strategy

- good for systems that use dependency injection

Repository

- data access pattern
- really good a decoupling the system with concerns
- works well with other patterns especially strategy

Adapter

- probably already familiar

Factory

- tightly related to ioc container
-

Proxy/Decorator

- these two are structurally similar
- useful for stacking with other patterns

Singleton

- important to be applied correctly
- often not

## Key Takeaways

- design patterns are general solutions to existing patterns
- help avoid reinventing the wheel with inferior code
- help you communicate richly with your team
- try to have knowledge of a broad range of patterns
- focus in on most relevant to your work
- use of good refactoring is important
