## What the heck is a functor?
The `Functor` type class is simply a class for types that can be mapped over.

```haskell
class Functor f where
    fmap :: (a -> b) -> f a -> f b
```

Note that the type variable f can look a little strange. (Initially I have been confused because I read it as a function). Here `f` is parameterised by a: `f a`.

`fmap` is the generalization of map for any parameterised data type.

### The functor laws
The role of these laws is to ensure that `fmap` behaves sanely and actually performs a mapping operation and not some other nonsense.

```haskell
fmap id = id
```

Mapping the identity function over a functorial value must leave the functorial value unchanged.

```haskell
fmap (g . f) = fmap g . fmap f
```

It should not matter whether we map a composed function or first map one function and then the other.

Here is an example with `int list` in `F#`: where `list` is the functor.
```fsharp
let values = [1;2;3]

let double x = x * 2
let triple x = x * 3

let res = values |> List.map (double >> triple)
let res' = values |> List.map double |> List.map triple

res = res' // true
```
