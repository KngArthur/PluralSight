# Naming

## Why is Naming Critical

- understanding intent is the biggest problem in refactoring and debugging
- bad or unclear names increase confusion
- names should read like a sentence

## Naming Classes

- well named classes are critical to maintenance
- avoid creating magnet classes
  - poorly named classes, with vague or abbreviated names
  - lazy developers tend to dump random variables into classes like this
  - can grow to be huge and unreadable
- a well designed class should have a single responsibility reflected in the name
- specific names encourage small cohesive classes

## Naming Methods

- good names are nouns
- specific class names form the foundation of design
- should be named and have a single responsibility
- name should strongly indicate that

### Avoid Generic Suffixes

- using generic names adds no value
- lowers the logical reading of the code
- generic examples
  - ______ info
  - ______ Manager

### Method Name Says it All

- method name should explain use
- only place method calls inside
- a good name doesn't require you to look inside it for its function

### Rubber Ducking

- talk to the duck
- verbalizing aids creativity
- helps to talk through code to name it appropriately
- also help identifying when concerns need separation

### Avoid Side Effects

- make sure method names are comprehensive
- don't leave surprise unnamed functions

### Avoid Abbreviations

- abbreviations were used when memory storage was very limited and expensive
- bad because there is no standard for abbreviations
- make is difficult to talk yourself through the code

### Naming Variables: Booleans

- difficult and trips up many developers
- well named variable should sound like a question asked
  - is Open
  - is Done
  - is Active
  - is Loggedin
- should ask a true false question

### Naming Variables: Be Symmetrical

- sometimes we deal with opposites
- should be clearly related
  - on/off    vs on/disable
  - fast/slow vs quick/slow
  - min/max   vs slow/max
