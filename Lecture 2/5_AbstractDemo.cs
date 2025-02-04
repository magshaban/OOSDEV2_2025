using System;

namespace ConsoleApplication1
{

    /* An abstract class contains at least 1 abstract method
     * An abstract method is a method that contains no implementation
     * An abstract method is just a definition
     * Therefore you cannot instantiate an object from an abstratc class
     *  e.g cant do  : Animal a = new animal
     * Therefore you must derive a class from the abstract class and 
     * create object from the drived class
     */

    public abstract class Animal
    {
        public bool IsAlive { get; set; }

        public void Breathe()
        {
            Console.Write("I am Breathing! ");
        }

        abstract public void Move();
    }


    //To use Animal functionality we must derive class from it and 
    public class Cat : Animal
    {
        public override void Move()
        {
            Console.Write("I am Cat,I'm lazy and I dont move!");
        }

        //
        //..other Cat Code
        //
    }
    

    class Test
    {       
        public static void Main()
        {
            //Cant create animal object
            //Animal a = new Animal();    <= WRONG
           
            Cat c = new Cat();
            c.Breathe();
            c.Move();
			
			
			//Note can do the following
			Animal a = new Cat();
			a.Move();    //References as an animal .. but it REALLY is a cat

            Console.ReadKey();
        }

    }
}