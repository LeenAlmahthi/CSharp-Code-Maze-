# C# Indexers

## What is it?

An **indexer** allows an object to be accessed using the `[]` syntax, similar to an array.

Instead of:

```csharp
playlist.GetSong(0);   We Call it as a proparity 
```

we can write:

```csharp
playlist[0];     We call it as a index 
```

The indexer defines what `object[index]` means for a class.

---

## Why do we use it?

Indexers are useful when a class manages a collection internally and we want to provide controlled access to its elements.

For example, a class can keep an array private:

```csharp
private string[] songs = new string[5];
```

and use an indexer to control how the outside code accesses that array.

---

## Syntax

```csharp
public string this[int index]   // we can chosse any datatype rether a void not allow 
{
    get
    {
        return collection[index];
    }

    set
    {
        collection[index] = value;
    }
}
```

The important part is:

```csharp
this[int index]
```

`this` defines the indexer, and `index` represents the value inside `[]`.


---

## Important Understanding

An indexer **does not automatically represent an array**.

---

## Multiple Indexes

An indexer can also accept multiple parameters:

```csharp
public string this[int row, int column]
{
    get
    {
        return cells[row, column];
    }

    set
    {
        cells[row, column] = value;
    }
}
```
---
###  Simple mental model

```text
object[index]
      ↓
   indexer
      ↓
 internal data
```