# Abstract Factory

Creational pattern in which we use separate factory classes to create products, for which a common interface (across the different factories exists).

The Abstract Factory pattern consists of

- Some Abstract Products
- An Abstract Factory 
- Some Concrete Factories
- Some Concrete Products

The different concrete factories are used to create specific concrete products leveraging the common interfaces. 

We can use polymorphism to swap out which concrete factory we are using when the scenario / desired products change.
