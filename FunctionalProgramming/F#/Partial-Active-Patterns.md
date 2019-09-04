Partial active patterns can only have 2 cases since it uses option.
```fsharp
let (|IsEven|_|) (input: int) = // int -> unit option
    if input % 2 = 0
    then Some IsEven
    else None
```

Note that this is also the same as:

```fsharp
let (|IsEven|_|) (input: int) = // int -> unit option
    if input % 2 = 0
    then Some ()
    else None
```

Since the type of the active pattern is `int -> unit option`.

This also makes sense when your active pattern returns a value (Since you can’t return an option of more than one type in the Some case.

```fsharp
// Valid
let (|FriendlyResponse|_|) (isNice: bool) =
    if isNice
    then Some (FriendlyResponse "Hello There Friend!")
    else None

// Which is equivalent to:
let (|FriendlyResponse|_|) (isNice: bool) = // bool -> string option
    if isNice
    then Some "Hello There Friend!"
    else None
```

Makes sense that partial active patterns can’t have more than one Some branch. And if you need more than 1 then just use a full active pattern :) (edited)

It’s also worth noting that you can compose partial active patterns in your match expressions:

```fsharp
let (|IsEven|_|) (input: int) = // int -> unit option
    if input % 2 = 0 then Some () else None

let (|IsLessThan100|_|) (input: int) = // int -> unit option
    if input < 100 then Some () else None

match 10 with
| IsEven & IsLessThan100 -> "Nice"
| _ -> "Something Else."
```

Finally both active patterns can even have payloads and still be composed:

```fsharp
let (|IsEven|_|) (input: int) = // int -> string option
    if input % 2 = 0 then Some "Even" else None

let (|IsLessThan100|_|) (input: int) = // int -> string option
    if input < 100 then Some "Less Than 100" else None

match 10 with
| (IsEven e) & (IsLessThan100 l) -> sprintf "%s and %s" e l
| _ -> "Something Else."
```
