# Abstract Class in C#

## Abstract Class Flow

```text
                    Car
              abstract class
                    |
          +---------+---------+
          |                   |
         BMW               Porsche
          |                   |
   override type()      override type()
          |                   |
       "BMW"             "Porsche"
```
virtual → has a base implementation
abstract → has no implementation
---

## The Main Idea

An **abstract class** is a class that is designed to be inherited from.

### Abstract Class

```text
Abstract class
      ↓
Cannot create an object directly
      ↓
Can be inherited
      ↓
Can contain normal methods
      ↓
Can contain abstract methods
```

For example:

```csharp
public abstract class Car
{
    public abstract void type();

    public void message()
    {
        Console.WriteLine("This is a car.");
    }
}
```

You **cannot** do:

```csharp
var car = new Car(); // ❌
```

because `Car` is abstract.

---

## Abstract Method

An abstract method contains only the **method declaration/signature**.

It does not contain an implementation.

```csharp
public abstract void type();
```

A derived class must implement it using `override`.

```csharp
public class Porsche : Car
{
    public override void type()
    {
        Console.WriteLine("Porsche");
    }
}
```

The same applies to BMW:

```csharp
public class Bmw : Car
{
    public override void type()
    {
        Console.WriteLine("BMW");
    }
}
```

---

## Normal Method in an Abstract Class

An abstract class can also contain normal methods with an implementation.

```csharp
public void message()
{
    Console.WriteLine("This is a car.");
}
```

Derived classes automatically inherit this method.

Therefore, we can simply call:

```csharp
car.message();
```

We don't need to override `message()` in `Porsche` or `BMW`.

---

## Polymorphism

Different derived classes can have the **same method name** but different implementations.

```text
                    Car
                     |
             type() method
                     |
          +----------+----------+
          |                     |
         BMW                 Porsche
          |                     |
       type()                type()
          |                     |
        "BMW"               "Porsche"
```

So:

```csharp
var car = new Porsche();
car.type();
```

calls the Porsche implementation.

While:

```csharp
var car = new Bmw();
car.type();
```

calls the BMW implementation.

This is an example of **polymorphism**.

---

## Sealed Class

A `sealed` class can be instantiated normally, but it **cannot be inherited from**.

```csharp
public sealed class Porsche
{
}
```

You can create an object:

```csharp
var car = new Porsche();
```

But this is not allowed:

```csharp
public class MyPorsche : Porsche
{
    // ❌ Cannot inherit from a sealed class
}
```

---

## Sealed Override

A method can also be marked as `sealed` when overriding a virtual/abstract method.

```csharp
public class Porsche : Car
{
    public sealed override void type()
    {
        Console.WriteLine("Porsche");
    }
}
```

This means:

```text
Porsche
   ↓
override type()
   ↓
sealed
   ↓
Further derived classes
cannot override type() again
```

---

## Summary

| Concept           | Meaning                                                                      |
| ----------------- | ---------------------------------------------------------------------------- |
| `abstract class`  | A class that cannot be instantiated directly                                 |
| `abstract method` | A method declaration without implementation                                  |
| `override`        | Provides/replaces the implementation of an inherited virtual/abstract method |
| Normal method     | Already has an implementation and can be inherited                           |
| Polymorphism      | Different classes provide different implementations of the same method       |
| `sealed class`    | A class that cannot be inherited                                             |
| `sealed override` | Prevents further classes from overriding that method                         |

### Key takeaway

```text
Abstract Class
      ↓
Provides a common structure
      ↓
Can contain implemented methods
      ↓
Can require derived classes
to implement abstract methods
      ↓
Derived classes can provide
their own behavior
      ↓
Polymorphism
```
