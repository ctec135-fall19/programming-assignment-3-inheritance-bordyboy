using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    // Create a class with two fields, one a string and the other an int. 
    // The class implements the IComparable interface.
    // https://docs.microsoft.com/en-us/dotnet/api/system.icomparable?view=netframework-4.8
    class SimpleClass : IComparable
    {
        // fields
        private string scStr;
        private int scInt;
        
        // properties to access private members
        public string ScStr
        {
            get { return scStr; }
            set { scStr = value; }
        }
        
        public int ScInt
        {
            get { return scInt; }
            set { scInt = value; }
        }
        
        // constructor
        public SimpleClass(string str, int x)
        {
            this.scInt = x;
            this.scStr = str;
        }
        
        // interface method
        // Objects in the class should be ordered in the following manner:
        //    * primary sort order is alphabetical according to the text field
        //    * secondary sort order is largest first according to the int field
        // int IComparable.CompareTo(object obj)
        public int CompareTo(object obj)
        {
            // cast obj to MyClass type
            SimpleClass sc = obj as SimpleClass;
            
            // if cast successful make comparisons
            if (sc != null)
            {
                // return value corresponding to comparison
                if (String.Compare(this.ScStr, sc.ScStr) < 0) return -1;
                if (String.Compare(this.ScStr, sc.ScStr) > 0) return 1;
                else // strings are the same - compare ints
                {
                    if (this.ScInt < sc.ScInt) return -1;
                    if (this.ScInt > sc.ScInt) return 1;
                    else return 0;
                }
            }
            else
                throw new ArgumentException("Parameter is not a MyClass object ");
        }
        
        // override ToString so can print object
        public override string ToString()
        {
            return $"{ScStr}, {ScInt}";
        }
    }
}