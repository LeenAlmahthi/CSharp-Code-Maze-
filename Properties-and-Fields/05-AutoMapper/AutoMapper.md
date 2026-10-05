# AutoMapper

## What is it?

AutoMapper is a .NET library that automatically maps data from one object to another. We can also add rules to control how the properties are copied.

Instead of manually copying each property:

```csharp
var dto = new StudentDto
{
    Id = student.Id,
    Name = student.Name,
    Email = student.Email
};
```

AutoMapper can do it for us.

## Why do we use it?

It reduces repetitive code when converting between objects such as:

```text
Student → StudentDto
Entity  → DTO
```

## Basic Mapping

First, define the mapping:

```csharp
cfg.CreateMap<Student, StudentDto>(); // Builds the mapping
```

Then perform the mapping:

```csharp
var studentDto = mapper.Map<StudentDto>(student); // Uses the mapping
```

AutoMapper automatically copies matching properties.

The default behavior is to match properties by name.

For example:

```text
Student.Name → StudentDto.Name
Student.Age  → StudentDto.Age
```

## Property Mapping

When we need to map two objects but the property names are different, we can tell AutoMapper how to map them:

```csharp
cfg.CreateMap<Student, StudentDto>()
    .ForMember(
        dest => dest.FullName,
        opt => opt.MapFrom(src => src.Name)
    );
```

This means:

```text
Student.Name → StudentDto.FullName
```

## Examples of Rules We Can Add

### Ignore a Property

If we don't want AutoMapper to copy a destination property:

```csharp
cfg.CreateMap<Student, StudentDto>()
    .ForMember(
        dest => dest.Password,
        opt => opt.Ignore()
    ); // Add a rule to the mapping
```

Now `Password` will not be mapped.

## Key Idea

```text
CreateMap()
      ↓
Defines the mapping

Map()
      ↓
Performs the mapping

ForMember()
      ↓
Adds a rule for a destination property

Ignore()
      ↓
Skips a destination property
```