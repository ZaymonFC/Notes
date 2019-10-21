# Tips and Tricks
> A growing list of tips and tricks on various conventions and patterns used within F#.

## Architecture
- Dependencies flow from the edge into the domain.
- Architecture can be thought of as concentric rings of infrastructure around your domain code.
- Favor ports and adapters style architecture.

## Testing
- Test business logic with unit tests
- IO and other side-effecty things should be tested through integration testing.

## High-Level Design
- Alternate between top-down and bottom up approaches
Sometimes it can be beneficial to alternate between approaches. Try alternating between decomposing the problem into smaller subproblems and building up the solution from smaller primitives and then plugging them together using `adapters`.

## Function formatting
Use a mix of `Stanza` and `Recipe` style.

Stanza:
```fsharp
let func x =
    // Chunk 1
    do this
    thenThis this
    thenThis

    // Chunk 2
    ...
```

> So it's called stanza style because the functions end up looking like stanza's in a poem?

Yes.

Recipe:
```fsharp
let func x =
    let prerequisite1 = ...
    let prerequisite2 = ...
    let prerequisite3 = ...

    x
    |> prerequisite1
    |> prerequisite2
    |> prerequisite3
```
> Why is this approach called *recipe*?

It's like you're baking a cake. You need to get all the ingredients ready before you can orchestrate the cooking. Just like being a chef it's important to have all the ingredients *mise en place* so you can clearly see a difference between the preparation and the actual orchestration of the cooking.

## General Tips
- Avoid using `_` as a wildcard pattern in match statements.

## Errors
> How do I handle handling of errors within my domain?

Try to make common errors obvious. Always favor returning results or options instead of blindly throwing exceptions.

> Should I always do this though?

No. It's important to understand the difference between a `domain error` and a `panic`.

> What's the difference?

Panics are generally errors that occur not because some domain rule has been invalidated, but some invalid state or construct has caused a more technical oriented exception.

> What do I do to handle *panics* then?

Panics don't need to be exposed to the domain. You can throw an exception and have it bubble up to some higher level handler for resilience.
