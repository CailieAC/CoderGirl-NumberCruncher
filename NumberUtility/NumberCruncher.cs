using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    //Complete the Number Cruncher program that has a static method to 
    //find the sum of all the even numbers in a list. 
    //This method should be in a class called NumberCruncher in its own class library called NumberUtility. 
    //Within your console project, create a list with at least 10 integers and call your method on the list.

    class NumberCruncher
    {
        public static int SumAllEvens(List <int> numberList)
        {
            int sumOfEvens = 0;
            int count = 0;
            foreach (int number in numberList)
            {
                if(count%2==0)
                {
                    sumOfEvens += number;
                    count++;
                }
            }
            return sumOfEvens;
        }

    }
}
