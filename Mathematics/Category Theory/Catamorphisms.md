# Notes on Catamorphisms

> A catamorphism isa general abstraction that enables you to handle multiple values - in order to reduce them to a single value.

Catamorphism is the morphism of reducing many values to a single value. This is commonly called `reduce`, `collect`, `aggregate` and `accumulate`.

> A fold is a catamorphism, but a catamorphism is a more general abstraction. For some data structures, the catamorphism is more powerful than the fold, but for collections, there's no difference.

For some data structures, the Catamorphism cannot be expressed with `fold` such as `Peano numbers` or `Boolean Values`. Data structures such as `Either` or `trees` support folding, but the fold is based on the catamorphism.
