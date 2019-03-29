using System;
using System.Collections.Generic;

namespace NumberCruncher
{
    public static class Program
    {
        public static void Main()
        {
            //Complete the Number Cruncher program that has a static method to 
            //find the sum of all the even numbers in a list. 
            //This method should be in a class called NumberCruncher in its own class library called NumberUtility. 
            //Within your console project, create a list with at least 10 integers and call your method on the list.

            List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(NumberUtility.NumberCruncher.SumOfEvenNumbers(numberList));

            Console.ReadLine();
        }
    }
    
}
