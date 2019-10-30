/*
Author: Bogdan Livadaru
Date:   10/21/2019
CTEC 135: Microsoft Software Development with C#
​
Module 4: Programming Assignment 3, Problem 5
  * Create a class with two fields, one a string and the other an int. 
      The class implements the IComparable interface.
  * Create appropriate methods for the class
  * Objects in the class should be ordered in the following manner:
      - primary sort order is alphabetical according to the text field
      - secondary sort order is largest first according to the int field
  * Demonstrate the the objects can be sorted according to requirement
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            // create some objects to use for testing
            SimpleClass sc1 = new SimpleClass("B", 2);
            SimpleClass sc2 = new SimpleClass("A", 1);
            SimpleClass sc3 = new SimpleClass("C", 1);
            SimpleClass sc4 = new SimpleClass("B", 1);
            SimpleClass sc5 = new SimpleClass("B", 2);
            SimpleClass sc6 = new SimpleClass("B", 3);
            
            // test logic - expect positive, i.e. B follows A
            Console.WriteLine(sc1.CompareTo(sc2));
            Console.WriteLine();
            
            // put test objects in array
            SimpleClass[] mcArray = new SimpleClass[6];
            mcArray[0] = sc1;
            mcArray[1] = sc2;
            mcArray[2] = sc3;
            mcArray[3] = sc4;
            mcArray[4] = sc5;
            mcArray[5] = sc6;
            
            // sort array
            Array.Sort(mcArray);
            
            // print sorted array
            foreach (SimpleClass item in mcArray)
                Console.WriteLine(item);
        }
    }
}