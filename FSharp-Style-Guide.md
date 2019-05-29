# FSharp Style Guide
This is an opinionated style guide for FSharp.

## Naming Conventions
### Namespaces and Modules

### Local functions, parameters and variables

### Types

### Generic Parameters


### Parameter Lists
Parameter lists for functions can quickly become unwieldy, especially for functions that have lots of dependencies to be applied.
```fsharp
let someFunction (parameter1: type1) (parameter2: type2) (parameter3: type3) (parameter4: type4) =
    ...
    ()
```
If parameters are too long or numerous and exceed the maximum column number it is good for readability to new line them.

```fsharp
let someFunction
    (parameter1: type1)
    (parameter2: type2)
    (parameter3: type3)
    (parameter4: type4) =

    ...
    ()
```
> Note a new line after the parameter list is preferred but up to personal preference.

### Pattern Matching

### Records
### Discriminated Unions
