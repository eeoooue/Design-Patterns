# Template Method

The template method pattern creates a skeleton indicating common structure found in a shared behaviour. 

A template method itself consists of calls to other methods within the class, some of which are abstract or virtual i.e. implemented by the specialised children of the class in which the template method exists.

In the template method pattern we should find:
- An abstract class containing the template method
- Virtual or abstract methods in the class containing the template method
- children of the class which override methods called by the template method
