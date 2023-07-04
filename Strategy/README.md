# Strategy

The strategy pattern offers an alternative to inheritance for code reuse. In the strategy pattern, we create Interfaces for behaviours and create concrete implementations of the behaviours as individual classes. This way, we can give the same specific behaviour to different classes wherever needed.

In the strategy pattern we should find:
- A **Strategy** interface that outlines a method for a behavioural theme
- **ConcreteStrategies** that implement the strategy outlined by the interface
- An abstract **Context**
- **ConcreteContexts** that have a ConcreteStrategy
