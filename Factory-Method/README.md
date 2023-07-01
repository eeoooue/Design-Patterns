# Factory Method

Creational pattern in which we move object instantiation occuring within a class into a method.

The objects instantiated in this method are our Products, for which we can have an abstraction / interface.

Our creators should implement the factory method, which returns a product. Our concrete creators can create specialized concrete products.