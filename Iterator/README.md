# Iterator

The iterator pattern provides a consistent interface for iterating through different collections of a family of objects, regardless of the nature of the individual collections.
For example, if we stored the same record object in different ArrayList, Dictionary and Tree collections, we might introduce this pattern.

In the iterator pattern we should find:
- An **Iterator** interface which outlines HasNext() and Next()
- Some abstraction **Product** for the items stored in the different collections
- A **Collection** interface which outlines GetIterator()
- **ConcreteCollections** of the Products
