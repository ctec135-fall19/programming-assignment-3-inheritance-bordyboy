using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            //an array of the base class type is created and initialized
            // with a member of each class in the hierarchy

            Drive[] myArray = new Drive[3];
            myArray[0] = new Drive();
            myArray[1] = new Folder();
            myArray[2] = new File();


            // Show that a method belonging to the base class is called from a child instance
            //create ParentMethod() in Parent and iterate through array
            // calling this method to demonstrate that all child classes have access to it
            foreach (Drive element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.DriveMethod();
            }
            Console.WriteLine();

            //-----------------------------------------------------

            //Demonstrate overriding a base class method by a child
            //parent-virtualMethod| child-overrideMethod

            foreach (Drive element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.OverrideMethod();
            }
            Console.WriteLine();

            //--------------------------------------------------------

            //Demostrate a child method calling the parent's method
            //create a virtual method in parent
            // override in child and call the parent as part of the implementation.
            foreach (Drive element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.Method2();
                Console.WriteLine();
            }
            Console.WriteLine();

            //-------------------------------------------------------

            //Demonstrate use of "as" keyword
            //repeat calls to someMethod
            foreach (object element in myArray)
            {
                
                Drive d = (Drive)element;
                Console.Write("{0}: ", d.GetType());
                d.OverrideMethod();
            }


            //---------------------------------------------------

            //Demonstrate use of "is" keyword
            Console.WriteLine("Demo use of is");
            foreach (Drive element in myArray)
            {
                if (element is File) Console.WriteLine("grandChild");
                else if (element is Folder) Console.WriteLine("Child");
                else if (element is Drive) Console.WriteLine("Parent");
            }
            Console.WriteLine();


            //------------------------------------------------------

            //switch
            Console.WriteLine("Demo Switch");
            foreach (Drive element in myArray)
            {
                switch (element)
                {
                    case File fi:
                        Console.WriteLine("GrandChild");
                        break;
                    case Folder fo:
                        Console.WriteLine("Child");
                        break;
                    case Drive d:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;

                }
            }

            //----------------------------------------------------

            //Create an object of"object type, but initialized of the 
            //base class type, then cast it to the actual type so you can call a method
            object obj = new Drive();
            ((Drive)obj).DriveMethod();

            Drive d2 = new File();
            ((File)d2).SpecializedMethod();
        }
    }
}
