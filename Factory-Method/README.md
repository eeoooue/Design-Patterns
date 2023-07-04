# Factory Method

In the factory method pattern, we delegate object instantiation to a specific method in a class, the factory method.

We create an interface outlining the object and make the factory method abstract. 

We then implement the object instantiation in specific subclasses, which should be interchangeable.

In the factory method pattern we should find:
- A **Product** interface outlining behaviour of a product
- **ConcreteProducts** which are different implementations of the product interface
- An **AbstractCreator** containing an abstract **FactoryMethod** with a return type of **Product**
- **ConcreteCreators** which implement this **FactoryMethod** and return a **ConcreteProduct**
