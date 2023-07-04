# Observer

The observer pattern creates a one-to-many subject-observer relationship.
The subject maintains a list of subscribed observers, each of which can be notified when the subject changes state.

In the observer pattern we should find:
- A **Subject** interface which outlines Notify() Register() & Unregister()
- An **Observer** interface which outlines Update()
