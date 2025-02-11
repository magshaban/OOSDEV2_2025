// demo of polymorphic references and polymorphic collections

using System;
using static System.Console;                // C# 6

namespace AnimalKingdom
{
    // abstract class, can't instantiate i.e. Mammal m = new Mammal()
    public abstract class Mammal : Object
    {
        // auto property, get only
        public string Name { get; }

        // constructor
        protected Mammal(String name)               // constructors of abstract classes should not be public
        {
            this.Name = name;				        // set the name
        }

        // abstract method - no body, class must be abstract
        abstract public void MakeSound();			// virtual is implied	
    }


    // a Dog isa Mammal
    public class Dog : Mammal
    {
        // Name property inherited, MakeSound method inherited

        // constructor
        public Dog(String name): base(name)
        {
        }

        // override inherited abstract method
        public override void MakeSound()
        {
            WriteLine(this.Name + " says " + this.Bark());
        }

        // new member
        public String Bark()
        {
            return "bow wow";
        }
    }

    // a Cat isa Mammal
    public sealed class Cat : Mammal		    // can't subclass			
    {
        // constructor
        public Cat(String name) : base(name)
        {
        }

        // override inherited abstract method
        public override void MakeSound()
        {
            WriteLine(this.Name + " says meow");
        }
    }

    // test class
    public class AnimalTest
    {
        public static void Main()
        {
            Mammal m = new Dog("Snoop");            // polymorphic reference, normallly Dog d = new Dog("Snoop")
            m.MakeSound();					        // polymorphic method call - at run-time determine actual object type

            if (m is Dog)                           // a Dog or any subclass of Dog?
            {
                WriteLine(m.Name + " isa Dog");
                Dog d = (Dog)m;                     // cast, or Dog d = m1 as Dog
                WriteLine(d.Bark());                // Bark can only be called on Dog references
            }

            // polymorphic collection of mammals
            Mammal[] mammals = { new Dog("Pluto"), new Cat("Kitty") };
            foreach (Mammal mammal in mammals)      // arrays are enumerable
            {
                mammal.MakeSound();
            }
        }
    }
}
