# Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from clients that use it.

## The problem

When we have several types of "something", and all these types have the same functionalities/behaviorus, but the way to be held is different between all of them, but sometimes they have some of them in common.

**For example**: we have several types of birds of prey, all of them can fly, but some of them flap a lot their wings like hawks, sparrow hawk, or not moving them a lot and getting advance of the air flows (they fly in circles), like eagles, buzards, condors or owls.

**Another example**: we have several types of cars, all of them can brake, but some of them use cam brakes, others use disc brakes, and others use wedge brakes.

**Another one**: animals can move: Some of them **walk** (dogs, cats, humans), others **jump** (kangoroos or rabits, grasshopper -_saltamontes, gafanhoto, cavalletta, grashüpfer_-), **swim** (tuna, sharks, whale, pinguin ) or **fly** (pigeon, dove), **crawl** (snakes, worms, snails).


The functionality/behaviour is common, but the way to do this is different sometimes.

So if we think about this as object, we could have an abstract or parent class "animals" with a method "move" (and maybe a implementation of any move, for example walk - or not-), but then all the children classes need their own implementation of "move".

- The class dog, has "walk" as implementation of "move".
- The class cat, has "walk" as implementation of "move".
- The class horse, has "walk" as implementation of "move".

Imagine that "walk" is a 20 lines of code method.
And we will have a lot of code replicated.

Of course we need to have another function with that common code.

