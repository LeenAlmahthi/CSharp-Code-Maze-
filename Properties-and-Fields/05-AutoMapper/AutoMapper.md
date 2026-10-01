# AutoMapper

## What is it?

AutoMapper is a .NET library that automatically maps data from one object to another.

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
cfg.CreateMap<Student, StudentDto>();     // here we builds a mapper 
```

Then perform the mapping:

```csharp
var studentDto = mapper.Map<StudentDto>(student);   // use the mapper 
```

AutoMapper automatically copies matching properties.

## Ignore a Property

If we don't want AutoMapper to copy a destination property:

```csharp
cfg.CreateMap<Student, StudentDto>()
   .ForMember(dest => dest.Password, opt => opt.Ignore());    // Add roles to the mapper 
```

Now `Password` will not be mapped.

## Key Idea

```text
CreateMap()
      ↓
Defines how objects are mapped

Map()
      ↓
Performs the mapping

Ignore()
      ↓
Skips a destination property
```