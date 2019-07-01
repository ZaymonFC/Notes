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

Having identity allows us to handle:
- How can I `reduce` on an empty list?
- What value should I start with if I have no data?

## Relationship to Semigroup
Monoids are semigroups with `Identity`

## Why does this matter? ᕙ(˵ ಠ ਊ ಠ ˵)ᕗ
In terms of real world programming collections or sequences of monoids can be reduced to a single value.

In addition thanks to the `Associativity` law they can be combined non sequentially which lends itself very well to parallel approaches such as `Divide and Conquer`.

## Examples

### The Angle Monoid
Addition of angles is a good example of a monoid. In fact most numerical addition or multiplication can generally be massaged into a monoid.

#### Binary Operator


#### Associativity


#### Identity
