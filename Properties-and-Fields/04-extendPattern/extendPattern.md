# Extended Property Patterns

## What is it?

Extended property patterns are used to **check nested properties of an object** in a shorter and cleaner way.

They can make complex `if-else` conditions easier to express using pattern matching.

## Why do we use it?

Instead of checking nested properties with multiple conditions:

```csharp
if (student.University.Address.City == "Amman")
{
    return "Amman Student";
}
else
{
    return "Other Student";
}
```

We can use a switch expression:

```csharp
return student switch
{
    
    {University.Address.City :"Amman" } => "Amman Student",
    {University.Address.Country: "Jordan",
        Age: >=18 } => "Jordan Adult Student",
    {University.Name :"Al-Balqa" } => "Al-Balqa Student",
    _ => "Other Student"
};
```

## Key Syntax

```csharp
{ Object.Property.NestedProperty: value }
```

Example:

```csharp
{ University.Address.City: "Amman" }
```

means:

```csharp
student.University.Address.City == "Amman"
```

### Remember

- `{ }` → pattern
- `.` → navigate through nested properties
- `:` → value the property must match
- `_` → anything else
- Patterns are checked from **top to bottom**