                    C# TYPES

              ┌───────────────────┐
              │ Reference Types   │
              └───────────────────┘
                    /       \
                   /         \
              class       record class
                ↓               ↓
          reference       value equality
           equality


              ┌───────────────────┐
              │    Value Types    │
              └───────────────────┘
                    /       \
                   /         \
              struct      record struct
                ↓               ↓
          value semantics   value semantics
                           + record features


int number = 10;

object obj = number; // boxing

                            p
                        ┌──────────────┐
                        │ X = 10       │
                        │ Y = 20       │
                        └──────────────┘
                        
                               │
                               │ boxing → COPY
                               ↓
                        
                        obj ───────→ ┌──────────────┐
                                     │ X = 10       │
                                     │ Y = 20       │
                                     └──────────────┘
                                      object on heap

object obj = 10;
int number = (int)obj;

                                          object
                                            ↓
                                          boxed int
                                            ↓ cast
                                            int

CLASS
→ Reference type
→ Assignment copies the reference
→ Normally reference-based equality
→ Good for complex entities/objects


RECORD CLASS
→ Reference type
→ Assignment copies the reference
→ Value-based equality
→ Good for data-oriented objects / DTOs


STRUCT
→ Value type
→ Assignment copies the value
→ Value semantics
→ Good for small, simple value-like data


RECORD STRUCT
→ Value type
→ Assignment copies the value
→ Value semantics
→ + record-generated functionality
→ Good when you want record behavior but still want a value type

Class: defines the structure and behavior. 

object: is an [instance] of that class, with its own instance data, and can access the class's accessible members.
public
→ Accessible from anywhere that can access the containing type.

private
→ Accessible only inside the containing class.

protected
→ Accessible inside the containing class and derived classes.
→ Not directly accessible from an ordinary object in Main.

internal
→ Accessible from code in the same assembly/project.
→ Not normally accessible from another project/assembly.

Default class
→ internal

Default class member
→ private