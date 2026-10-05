# Reflection

## What is it?

Reflection is a C#/.NET concept that allows us to inspect and access information about types at runtime.

For example, if I have a property name as a string, I can use Reflection to find that property and get its value instead of accessing it directly with `object.PropertyName`.

## Flow

```text
typeof(Person)
      ↓
Type object
      ↓
GetProperty("Age")
      ↓
PropertyInfo object
      ↓
GetValue(person)
      ↓
22
```

## PropertyInfo

```csharp
PropertyInfo? property =
    typeof(Person).GetProperty(propertyName);
```

`PropertyInfo` holds information about the property that was found.

For example, if `propertyName` is `"Age"`, it represents information about the `Age` property.

## GetValue()

```csharp
object? value =
    property?.GetValue(person);
```

`GetValue()` gets the actual value of the property from the specified object.

It returns `object?` because the property can have different data types.

For example:

```text
Age  → int
Name → string
```