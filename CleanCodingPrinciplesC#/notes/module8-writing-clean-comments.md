# Writing Clean Comments

- comments should only be chosen as a solution as a last resort
- comments lie
  - not kept up to date
  - can be made left to be redundant
  - can be a crutch for bad code
- alternatively can be necessary as conveying intent without is not easy
  - developers often assume their code is descriptive when it's not

## Comments: A Necessity and a Crutch

### Prefer expressive code over comments

- strive to make it clear with descriptive code over comments
  - code is more likely to be updated
  - is a more definitive reference for the function
- Use comments when code isn't sufficient

### Redundant Comments

- repeat what the code says, right next to it
- Break the DRY principle
- needless repetition without any added value
- lower the signal to noise ratio
- avoid requiting comments on every method, just name them better

How To Avoid

- Assume your reader can read code in the language
- Don't repeat yourself

### Intent

- often used to describe a magic number or other vague variable
- Can often eliminate intent comments via a well named constant

How To Avoid

- improve function name
- declare intermediate variable
- declare a constant or enum
- extract conditional to function

### Apology

- sign a developer didn't finish the job
- usually addressing an exception

How To Avoid

- always fix before commit/merge
- add a TODO marker comment if you must leave it

### Warning

- similar to apology comment
- warnings that lousy code is ahead
- usually mean code can only be touched by a particular person

How To Avoid

- code should be refactored to fix

### Zombie Code

- commented out pieces of code
- commented out code is alive because its still appears in searches
- left in because developers find it risky to delete
- commented code is in the way, less is more
- hoarding mentality adds noise and technical debt
- creates ambiguity on if the code should or should not be used, deleted, or refactored
- Automated refactoring tools do not touch commented code
  - can "leave behind" code and a mess if used later

How to Avoid

- a project with proper source control allows you to access past versions
- no need to keep commented code
- ask yourself
  - when would it be uncommented
  - can i get it from source control later
  - is this incomplete work that should be work on via branch
  - should this be toggled via configuration setting
  - did i refactor out the need for this code

### Divider

- when functions get too long developers add comments to split up code

How to Avoid

- refactor each commented part into its own function

### Brace Tracker

- used to help navigate really long code
- comment on closing ends of brace's
- help identify ends of functions

How to Avoid

- refactoring to a function
- wrapping deeply nested variables into a function tracks better

### Bloated Header

- standard boiler plate template at the top of all files

How to Avoid

- avoid template designs with characters or lines
- avoid line endings
- don't repeated yourself
  - file name is shown
  - name and date available through source control

### Defect Log

- Comments logging changes and defects
- show the timeline of the fixes

How to Avoid

- no need when using source control
- should be logged in source control

## Clean Comments

### To Do

- allow dev to get back to a specific place in code that needs to be done later
- boarder line clean because they can be overused
- start with TODO, HACK, UNDONE
- can be handy way to keep track of open items in the short term

How To Use

- standardize the comment so intent is clear
- watch for using them as apology or warnings

### Summery

- act as an intro at start of the book
- provide high level overview of classes
- Describe intent at general level without looking through code
- convey scope and interactions

How to Use

- always seek to convey with code first

### Documentation

- help provide documentation where it's useful in the code
- very helpful when working with a 3rd party
