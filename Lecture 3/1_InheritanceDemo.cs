// demo of inheritance

using System;

namespace Human
{
    public class Person : Object
    {
        private String name;                        // person's name
        private String gender;                      // male or female

        // constructor
        public Person(String name, String gender)   // : base()
        {
            this.name = name;				        
            this.gender = gender;
        }

        // virtual means this can be overriden in sublcass
        public virtual String GetHumanType()        
        {
            return "a Person";
        }

        // override member inherited from Object, defined as virtual in superclass
        public override String ToString()
        {
            return "Name: " + name + " Gender: " + gender;
        }


    }

    public class Musician : Person					// a Musician "isa" Person
    {
        private String favouriteInstrument;

        // name and gender not inherited since private in superclass
        // can inherit properties also
        // public and protected members inherited (except for constructors)
        // private members not inherited

        // constructor
        public Musician(String name, String gender, String favouriteInstrument)
            : base(name, gender)         // call base class constructor
        {
            this.favouriteInstrument = favouriteInstrument;
        }

        // override inherited member, access modifier must match
        public override String GetHumanType()               // override is implicity virtual and can be overridden in subclass
        {
            return "a Musician";
        }

        // override member inherited from Person, call base class method and append instrument name
        public override String ToString()
        {
            return base.ToString() + " Favourite Instrument: " + favouriteInstrument;
        }

    }

    // test class
    public class Test
    {
        public static void Main()
        {
            Person p1 = new Person("Gary", "Male");
            Console.WriteLine(p1.GetHumanType() + ", " + p1);

            Musician p2 = new Musician("Ringo", "Male", "Drums");
            Console.WriteLine(p2.GetHumanType() + ", " + p2);
        }
    }
}
