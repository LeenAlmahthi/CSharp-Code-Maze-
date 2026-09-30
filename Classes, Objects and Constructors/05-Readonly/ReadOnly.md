# What is readonly?

The `readonly` modifier means that a field can only be assigned:

1. When it is declared.
2. Inside a constructor.

After the object has been constructed, the field cannot be
assigned a new value.

Example:

    private readonly string make;

The value of `make` can be assigned in the constructor:

    public Car(string make)
    {
        this.make = make;
    }

But it cannot later be changed:

    car.make = "Audi"; // ERROR
    // `make` is private and readonly.


# PRIVATE FIELD vs PROPERTY

A private field cannot be accessed directly from outside
the class.

    private readonly string make;

Therefore, the class needs to expose the value if outside
code needs to read it.


There are different ways to expose a private field.


# 1. READ-ONLY PROPERTY

    public string Make => make;

This is an expression-bodied property.

It allows outside code to READ the value:

    Console.WriteLine(car.Make);

But outside code cannot assign a new value:

    car.Make = "Audi"; // ERROR

So:

    private readonly string make;
                  ↓
    public string Make => make;

The field stores the value.
The property provides controlled access to the value.


# 2. METHOD

The same private field can also be exposed through a method:

    public string GetMake()
    {
        return make;
    }

Then:

    Console.WriteLine(car.GetMake());

Both approaches allow the caller to read the private field.

Property:

    car.Make

Method:

    car.GetMake()


# PROPERTY SYNTAX

Expression-bodied read-only property:

    public string Make => make;

This is equivalent to:

    public string Make
    {
        get
        {
            return make;
        }
    }


# READ-ONLY vs READ-WRITE PROPERTY

READ-ONLY:

    public string Make => make;

or:

    public string Make
    {
        get;
    }

The caller can read the value but cannot assign it.

    Console.WriteLine(car.Make); // OK
    car.Make = "Audi";           // ERROR


READ-WRITE:

    public string Make
    {
        get;
        set;
    }

The caller can both read and modify the value:

    Console.WriteLine(car.Make);

    car.Make = "Audi";


IMPORTANT:

The `readonly` modifier applies to a FIELD:

    private readonly string make;

It does NOT mean the same thing as a read-only PROPERTY:

    public string Make => make;