
using System;
//using System.Collections.Generic;

namespace years_in_a_range
{
    class Program
    {
        static Boolean YearHasRepeatedDigit(int year)
        {
            string stringYear = year.ToString();
            char[] charYear = stringYear.ToCharArray();
            int t = 1;
            for (int i = 0; i < charYear.Length; i++)
            {
                
                for(int k = 0; k < (charYear.Length-1); k++)
                {
                   
                    if(charYear[i] == charYear[(k + t) % charYear.Length])
                    {
                        return true;
                    }

                }
                t +=1;
            }
            return false;
        }

        static void Main(string[] args)
        {
            /*Write a program to count the number years in a range that has a repeated digit.
             For example, 2012 has a repeated digit, but 2013 does not.*/

            Console.WriteLine("Enter starting year");
            int startNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end year");
            int endNum = Convert.ToInt32(Console.ReadLine());

            int count = 0;


            for (int year = startNum; year <= endNum; year++)
            {
                
                if (YearHasRepeatedDigit(year))
                {
                    count += 1;
                }
            }
            Console.WriteLine("Number of years with repeated digits: " + count);
        }
    }
}



