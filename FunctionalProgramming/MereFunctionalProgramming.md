# Notes from 'Mere Functional Programming'
[Article](https://dev.to/kspeakman/mere-functional-programming-in-f-do8)

## Types
Represent data with `records` and `unions`. These types are composable ADT's.

## Functions
- Functions should be one of the base units of computation.
- Functions should be deterministic (pure).
    - Deterministic functions are also called `Referentially transparent` or `Pure`
Although it will be necessary for your application to do anything useful to have functions with side effects, all important decisions should be made with deterministic functions.
