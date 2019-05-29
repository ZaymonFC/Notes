# FSharp Style Guide
This is an opinionated style guide for FSharp.

## Naming Conventions
### Namespaces and Modules
`namespaces` and `modules` are always `PascalCase`
```fsharp
namespace ConnectDevelop
    module BusinessModule =
        ..
```

### Local variables/functions, parameters and variables
Local variables/functions, function parameters and variables follow a standard `camelCase` style.
```fsharp
module RelatedFunctionality

let localFunction param =
    let localVariable = param
    ..
```

### Types
`types` are always `PascalCase`

```fsharp
type ConstrainedInt = ConstrainedInt of int
```

`type members` are also expressed with `PascalCase` to disambiguate them from `module members`

For Example:
```fsharp
type RecordType = {
    Field1: 
}
with
    static member ToDescription () =
        ..
```

### Generic Parameters


### Parameter Lists
Parameter lists for functions can quickly become unwieldy, especially for functions that have lots of dependencies to be applied.
```fsharp
let someFunction (parameter1: type1) (parameter2: type2) (parameter3: type3) (parameter4: type4) =
    ..
    ()
```
If parameters are too long it's beneficial to maintainability/readability to transpose the list to new lines.

```fsharp
let someFunction
    (parameter1: type1)
    (parameter2: type2)
    (parameter3: type3)
    (parameter4: type4) =

    ..
    ()
```
> Note a new line after the parameter list is preferred but up to personal preference.

### Pattern Matching

### Records
### Discriminated Unions


## Programming Conventions
### Useful links

### Pipelining