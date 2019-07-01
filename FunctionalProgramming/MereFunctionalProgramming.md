# Notes from 'Mere Functional Programming'
[Article](https://dev.to/kspeakman/mere-functional-programming-in-f-do8)

## Types
Represent data with `records` and `unions`. These types are composable ADT's.

## Functions
- Functions should be one of the base units of computation.
- Functions should be deterministic (pure).
    - Deterministic functions are also called `Referentially transparent` or `Pure`
Although it will be necessary for your application to do anything useful to have functions with side effects, all important decisions should be made with deterministic functions.
> In doing so you can verify important decisions with tests.

## Lessons from structured programming
Structured programming has 3 common control structures.
- `Sequencing`: executing one statement followed by another
- `Selection`: branching, commonly `if`, `switch / case`
- `Iteration`: looping constructs

Functional programming does not need to be rooted in category theory and more abstract/esoteric constructs to be productive.

In my opinion these things are additional tools to help people identify common laws, abstractions and model domains with increasing levels of specificity and constraint.
