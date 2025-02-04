using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    //Sample class has 1 static fields and 1 static method
    public class Sample
    {
        public static int count = 0;

        public Sample()
        {
            count++;   //instance had access to static members
        }

        public static int NumberOfObject()
        {
            return count;  
        }        
    }

    class Test
    {
        public static void Main()
        {
            Sample s1 = new Sample();
            Sample s2 = new Sample();
            Sample s3 = new Sample();

            var i = Sample.NumberOfObject();
            Console.WriteLine("There were " + i + " objects created") ; 
            Console.ReadKey();
        }
    }
}