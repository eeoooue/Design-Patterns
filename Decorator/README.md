# Decorator

Structural pattern in which we wrap a component object with a child of the object which extends its behaviour.
We can consider this an alternative to inheritance, as we're instead using composition.

The decorator pattern offers an alternative to inheritance for extending the functionality of an object. We can wrap an object with a decoration to add new functionality.

Some interface should exist for the wrapped object, which is implemented by the decorator, such that we can substitute the object for its wrapping decoration at runtime.

In the decorator pattern we should find

- A **Product** interface
- **ConcreteProducts** which implement the interface
- An **AbstractDecoration**
- **ConcreteDecorations**

The decorator pattern allows for highly specific customisation of a product at runtime.

