using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Drive
    {
        //Show that a method belonging to the base class is called
        //from a child instance
        public void DriveMethod()
        {
            Console.WriteLine("Drive method");
        }

        //demonstrating overriding a base class method by a child
        public virtual void OverrideMethod()
        {
            Console.WriteLine("Drive's OverrideMethod");
        }


        //Demostate a child method calling the parent's method
        public virtual void Method2()
        {
            Console.WriteLine("Drive.Method2");
        }
    }
}
