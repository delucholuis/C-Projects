//Luis Blas Lopez
//02-22-2018
//Project C# Foundations
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number Between 5 and 20 Below");
            int myResponse = int.Parse (Console.ReadLine());
            int i=1;
            while (i <= myResponse){
                Console.WriteLine(i + (i % 2 == 0 ? " is even" : " is odd"));
                i++;
            }
        }
    }
}
