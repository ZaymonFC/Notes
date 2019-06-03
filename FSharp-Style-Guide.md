# FSharp Style Guide
This is an opinionated style guide for FSharp.

## Useful links
### Control Flow and 'Patterns'
- [Railway Oriented Programming](https://fsharpforfunandprofit.com/posts/recipe-part2/) - Scott Wlaschin

## Spacing
### Indentation
Indentation scheme used throughout our projects is 4 spaces.

### Infix Operators 
Always surround infix operators with a space.
```fsharp
foo |> bar
1 + 2
fish >=> operator
```

### Type Annotations
In FSharp the convention seems to be unclear wether to space around the `:` or have it aligned to the left. In our codebases we choose to left align as a convention.
```fsharp
let func (param: type) =
    ..

type Foo = {
    Field: typeOfField
}
```


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

### Generic Parameters
FSharp type inference is very powerful. More often it's beneficial for generic parameters to remain inferred, as it allows for easy maintenance and refactoring. However, in the case where specifying generic parameters are required here are some conventions:
- All generic parameters are prefixed with an apostrophe. Eg: `'a`
- Generic parameters should use the letters
    - `'t 'u 'v`
    - `'a 'b`

Examples:
```fsharp
// Type Parameter
type <'t> WrappingType = {
    Field: 't
}

// Function Parameter
let genericFunction<'t, 'u, 'v> (param1: 't) (param2: 'u): 'v =
    ..
```

### Pattern Matching

### Records
### Discriminated Unions


## Programming Conventions

### Pipelining

