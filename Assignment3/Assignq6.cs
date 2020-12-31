using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment3
{
    class Assignq6
    {
        public static void arraysOfInteger()
        {
            //Declaring an array does not initialize the array in the memory. When the array variableis initialized, you can assign values to the array
            int[] Array1 = { 1, 3, -5, 4 }; // Creating array
            int[] Array2 = { 1, 4, -5, -2 }; // creating array
            //the two line is not mandatory
            Console.WriteLine("Array1:[{0}] ", string.Join(",", Array1)); // Invoking the join method.
            Console.WriteLine("Array2 : [{0}]", string.Join(",", Array2)); // Invoking the join method.
            for (int i = 0; i < Array1.Length; i++)// multiplication of array
            {
                int x = Array1[i] * Array2[i];
                Console.WriteLine("Multiplication pf array elemnet at index " + i + "  is : " + x);

                





















            {

                }

                //Assigning values to the array=

                //You can also create and initialize an array, as shown int [] Array1 = new int[4]  { 1, 3, -5, 4};



            }
        }
    }
}
