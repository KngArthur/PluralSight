# Clean Coding Principles

1. Right Tool For The Job
2. High Signal to Noise Ratio
3. Self Documenting

## Right Tool For The Job

- When selecting tools the risks sit at the boundaries of their intended purpose
    * always tempting to force the use of a familiar or already used tool for convenience
- the boundaries and interactions are where the risks exist
- reduces reusability and consistency
- Examples
    * injecting HTML in .js files
    * HTML in SQL
    * CSS in HTML
- avoid using one language to write in another language via strings
- Stay Native
    * it stays cached, injected code will not be available when not in use
    * can make use of tool like code coloring and syntax checking
    * separation of concerns allow the code to be easily understood
- leverage libraries to generate other formats
- ONE LANGUAGE PER FILE
    * always refactor to separate

### Every Tech is Potentially Evil

- before using a tech or process, ask if its designed for that use
- not doing this can lead to lengthy workaround later in the process

## High Signal/Noise Ratio

- you want to be concise and clear at all times
- Signal
    * any code that follows the TED rule
        * T = Terse
        * E = Expressive
        * D = Does one thing
- Noise
    * code that reduces readability and hinders maintenance

### Our Brian Is The Compiler

- follow the rule of 7 for human memory so humans can understand our code
    * can only remember 7 things easily at once

### The Mess Builds Quietly

- refactor regularly to stop the noise building up
- mess comes from ongoing changes with no refactoring
- computers can understand long messy code but humans cannot

### DRY Principle: Don't Repeat Yourself

- clean code states each piece of code at once and only once
- increases reliability and efficiently
- eases maintenance
- using Copy/Paste is a design problem
- duplicated code increases noise
- every line of code added is a liability
- you want to stay light and concise

### Look For Patterns

- duplication isn't always obvious
- keep an eye out for repeated shapes in the code
- patterns are a sign of redundancy

## Self Documenting

- All about writing code where intent is obvious
- proper names are the best way of achieving this
- the hardest part of maintenance is figuring out the original intent of the programmer

### Clear intent

- readers understand what is being accomplished

### Layers of Abstraction

- problem can be walked through step by step, and layer by layer

### Format for Readability

- optimizes the readers experience
- makes refactoring much easier

### Favor Code Over Comments

- insures code is expressive as it can be
- reduces or eliminates the need for out of band documents
- clearly and immediately expresses intent
