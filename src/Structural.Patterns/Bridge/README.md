# Bridge

This project contains an implementation of the **Bridge** design pattern. The purpose of this pattern is to **decouple an abstraction from its implementation**, allowing both to evolve independently. Instead of rigid class hierarchies, it uses composition to link two separate hierarchies—Abstraction and Implementor—making the system more flexible and easier to extend.

## What is the Bridge Pattern?

The **Bridge** is a **structural design pattern** designed to separate an abstraction from its implementation by placing them in separate class hierarchies. The abstraction contains a reference to an implementor and delegates implementation-specific work to it. This setup lets both sides vary independently and enables runtime swapping of implementations.

## Advantages

- **Decoupling**: Abstraction and implementation can change without affecting each other.
- **Flexibility & Extensibility**: You can add new abstractions and implementations freely.
- **Avoids subclass explosion**: No need to create a class for every combination of features.
- **Supports runtime binding**: Implementations can be changed dynamically.
- **Parallel development**: Teams can work separately on abstraction and implementation parts.

## Structure

1. **Abstraction**  
   Defines high-level methods and holds an `implementor` reference.
2. **RefinedAbstraction**  
   Implements or extends Abstraction, delegating detailed work to Implementor.
3. **Implementor**  
   Declares the interface for implementation classes—defines low-level operations.
4. **ConcreteImplementor**  
   Actual implementations, providing platform- or variant-specific behavior.