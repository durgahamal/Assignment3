using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assign8
    {
        public static void Cube()
        {
            int num1, i, f = 1;//cube of a number
            Console.WriteLine("Enter the number, ");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num1; i++)

            {

                f = i * i * i;





                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", i, i, f);
            }


        }
        
    }
}
        
        

        
    

