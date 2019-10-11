/*
Author:     Mike Hart
Date:       10/9/19
CTEC 135:   Microsoft Software Development with C#
<Module 2,  Programming Assignment 1 part 2 , Problem 2>   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for loop
            Console.WriteLine("for loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");
            #endregion

            #region while loop
            Console.WriteLine("while loop:");
            int count = 1;
            while (count <= 5)
            {
                Console.Write("{0} ", count);
                count++;
            }
            Console.WriteLine("\n");
            #endregion

            #region do/while loop
            Console.WriteLine("do/while loop:");
            count = 1;
            do
            {
                Console.Write("{0} ", count);
                count++;
            } while (count <= 5);
            Console.WriteLine();
            #endregion
        }
    }
}
