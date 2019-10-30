using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class File : Folder
    {
        // Demonstate overriding a base class method by a child
        public override void OverrideMethod()
        {
            Console.WriteLine("File's OverrideMethod");
        }
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("File.Method2");
        }

        public void SpecializedMethod()
        {
            Console.WriteLine("SpecializedMethod");
        }
    }
}
