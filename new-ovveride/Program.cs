public class Program
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal");
        }
        public virtual void Type()
        {
            Console.WriteLine("Animal");
        }
    }

    class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Dog");
        }
        public override void Type()
        {
            Console.WriteLine("Dog Type");
        }
    }
    public static void Main()
    {
        Animal animal = new Dog();
        animal.Speak();
        animal.Type();
        Dog dog = new Dog();
        dog.Speak();
        dog.Type();
        // Console.WriteLine("text: " ,  );
    }

}

// Animal animal = new Dog();

// Speak() → new       → Animal
// Type()  → override  → Dog Type


// Dog dog = new Dog();

// Speak() → new       → Dog
// Type()  → override  → Dog Type