# Observer Pattern

The Observer Pattern defines a one-to-many dependency between objects, so that when one object changes state, all of its dependents are notified and updated automatically.

## Problem

We have *one subject* and *many observers*, who need to be notified whenever something in the subject changes. To give a concrete example, you can think about multiple displays (*observers*) that should be updated whenever the value of a temperature sensor (*subject*) changes.

That means that the observser are *dependent* on the subject, they can interact, but they need to have very little knowledge of each other. We want to be able to add, remove, replace observers easily at any time, without changing the code of the subject. We also want to reuse subject and observers independently of each other.

Last but not least, we want a design that follows these basic principles:

- separate the aspects of the application that may vary from what stays the same
- program to an interface and not to an implementation
- strive for loosely coupled designs between object that interact

## Solution

![ObserverPattern](./img/observer.png)


### How to use it? A fun example