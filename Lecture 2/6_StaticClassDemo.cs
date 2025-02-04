using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    //NB : In Static Class ALL methods must be static
    public static class MathsUtilities
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }


    class Test
    {
        public static void Main()
        {
            //Note : I cant create an instance (object) from the MathsUtilities  static class
            //i.e  MathsUtilities m = new MathsUtilities()
            //I must call methods straight off the class         

            int ans1 = MathsUtilities.Add(10, 6);
            int ans2 = MathsUtilities.Subtract(10, 6);

            Console.Write("Answer 1 is " + ans1);
            Console.Write("Answer 1 is " + ans2);
        }
    }
    
}