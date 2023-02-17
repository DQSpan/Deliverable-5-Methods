/*
 Author: Dequandre Span
 Date: 2/16/2023
 Description: C# Random methods array
*/
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;

namespace Deliverable__5__Methods
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15");
                int input = int.Parse(Console.ReadLine());
                if (input is >= 5 && input is <= 15)
                {
                    int[] MyArray = random_array(input);
                    Console.Write("The elements in the random array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + sum(MyArray));
                }
                else if (input is < 5 || input is > 15)
                {
                    Console.WriteLine("Error enter an interger between 5 and 15");
                }
            }
            catch
            {
                Console.WriteLine(" Error: User entry not valid enter an interger");
            }
        }
    }
}   
        
    
