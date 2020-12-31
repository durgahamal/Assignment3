using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Assignq4
    {
        public static void Primenumbers()
        {
            
            // Prime numbers are greater then 1 that has no positivedivisors other then 1 and itself.
            Console.WriteLine("Sum of the first 500 prime numbers : ");
             bool isPrimeNumber = true;
            for(int i = 2; i<501 ; i++) // this is outer loop responsible for checking the maximum number  501
            {
                for (int k = 2; k<501; k ++) // this is inner loop resposible for checking the factors
                {
                    if (i != k && i % k == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                    if (isPrimeNumber)
                    {
                        Console.WriteLine(i);
                    }

                    isPrimeNumber = true;
            }
            Console.ReadLine();

                                                                                                                            
        }
    }
}
