using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignq5
    {
        public static void Integer()
        {
            int numA, sum = 0;
            Console.WriteLine("Input a number : ");
            numA = Convert.ToInt32(Console.ReadLine());
            
            // /= COMPUTE QUOTIENT

            while (numA != 0)//
            {
                sum = sum + (numA % 10);  // computes remainder 
                numA /= 10; // computes quotient// 12/10
            }
            Console.WriteLine("Sum of the digit of integer  :{0}", sum);
        }
    }
}
