# Factory Patterns

Here we would like to describe different approaches about using a Factory in your code. We can identify 3 different patterns, described in details below: the *Simple Factory*, the *Factory Method* and the *Abstract Factory*.

# Simple Factory

In the Simple Factory scenario, we basically have a factory class that is responsible for creating different types of object, based on a given input.

## Problem

You want your code to be flexible, so you decided to program to an interface, not an implementation. However, somewhere in your code you need to instantiate new objects, obviously. If you have multiple classes implementing the same interface and you need to instantiate different objects depending on a parameter, your code might become difficult to read and less flexible than what you expected.

Let's visualize the problem using a small example:

```cs
ICostume ViewCostume() {

  ICostume costume;

  if(captainAmerica) {
    costume = new CaptainAmericaCostume();
  } else if(ironman) {
    costume = new IronmanCostume();
  } else if(thor) {
    costume = new ThorCostume();
  } else if(blackWidow) {
    costume = new BlackWidowCostume();
  } ...

}
```

What if we want to add even more superheroes? This code is not as flexible as we thought when we created the `ICostume` interface, especially if this is part of a class that handles also the business logic of the application: every time that we add a new type of costume implementing the interface, we also need to change this code.

## Solution

The simplest solution is to encapsulate the objects creation moving that code in a `CostumeFactory` class:

```cs
public class CostumeFactory {

  public ICostume CreateCostume(string superheroe) {

    return superheroe switch
    {
      "CaptainAmerica" => new CaptainAmericaCostume(),
      "Ironman" => new IronmanCostume(),
      "Thor" => new ThorCostume(),
      "BlackWidow" => new BlackWidowCostume(),
      // to add a new superheroe costume, you just add a case here
      _ => null,
    };
  }
}
```

### Advantages of this solution

This might seem just a small trick, but the `factory` class has some interesting advantages:

- it can serve multiple classes
- it's the only place to change in case we need to add more superheroe costomes (besides the creation of the new class implementing the `ICostume` interface, obviously)
- it might be `static`: in that case you can use the `create` method without instantiating the object, but you lose the opportunity to subclass and change the behavior of that method

## How to use it

In the *SimpleFactorySample* folder you can find a small console application using the simple factory.

!["SimpleFactory"](\img\simpleFactory.png)

As you can see, the shop requires a factory to be able to actually instantiate the different costume objects. In this application, we actually have 2 different `CostumeShops` using the same factory, and you can easily view all the superheroes' costumes in both shops.
Whenever we want to add a new costume, we just need to create a new class implementing `ICostume` and add a new `case` in the `switch` statement of the `CostumeFactory`, so that the costume can be available to all shops using that factory.

### How to run

To run the sample app, you just need to run this commands:

```ps
cd SimpleFactorySample
dotnet run
```

This is the initial ouput you should see:

```
---- Shop1 ----
> Ironman's costume:
Red armor showing arc reactor
Red jet-boots
Red and gold helmet.
This is the list of accessories: Jarvis Gloves with repulsor rays
> Thor's costume:
Leather suit,
Black boots,
Helmet with wings.
This is the list of accessories: Mjölnir Red cape
...
```

# Factory Method

## Problem

## Solution

### Advantages of this solution

## How to use it

### How to run

# Abstract Factory

## Problem

## Solution

### Advantages of this solution

## How to use it

### How to run