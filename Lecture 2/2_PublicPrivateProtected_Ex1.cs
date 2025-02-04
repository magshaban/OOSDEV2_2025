using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    /*----  BASE CLASSS ---*/
    class Baseclass
    {
        private     int BPrivate    { get; set; }
        protected   int BProtected  { get; set; }
        public      int BPublic     { get; set; }


        void BFunc()
        {
            //Class has access to all its OWN members (private ,protected,public)
            BPrivate = 1;
            BProtected = 1;
            BPublic = 1;
        }
    }


    /*----  DERIVED CLASSS ---*/
    class DevivedClass : Baseclass
    {

        void DFunc()
        {
            //BPrivate = 1;    // ERROR : Nobody can view private vars of another class
            BProtected = 1;  //OK : derived class has access to protected vars of base class
            BPublic = 1;     //OK : Everybody has access to public members of any class
        }
    }

    class Test
    {
        public static void Main()
        {
            Baseclass obj = new Baseclass();

            //obj.BPrivate = 1;    // ERROR : Nobody can view private vars of another class
            //obj.BProtected = 1;  // ERROR : only code inside derived class has access to protected vars of base class
            obj.BPublic = 1;     //OK : Everybody has access to public members of any class
        }
    }
}