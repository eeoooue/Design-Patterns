# Observer

Behavioural pattern in which observer objects are notified when the subject object changes.

To implement the pattern, the subject maintains a list of observers and provides methods for being subscribed & unsubscribed to this list.

Observer classes should implement a common interface with their own Update() behaviour