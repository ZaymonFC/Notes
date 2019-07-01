# Monoids
What distinguishes a monoid from a semigroup? Let's find out.

## The Laws
A monoid is any structure which follows:
- Associativity
- Identity
- Binary combination SxS -> S

### Associativity
> "It doesn't matter how you arrange the brackets"

(a . b) . c = a . (b . c)

### Identity
There exists some element, that when you `combine` or `append` it with the original element you get the original element.

## Relationship to Semigroup
Monoids are semigroups with `Identity`

## Why does this matter? ᕙ(˵ ಠ ਊ ಠ ˵)ᕗ
In terms of real world programming collections or sequences of monoids can be reduced to a single value.

In addition thanks to the `Associativity` law they can be combined non sequentially which lends itself very well to parallel approaches such as `Divide and Conquer`.