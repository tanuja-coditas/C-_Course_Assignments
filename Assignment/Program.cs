
using System;
using System.Collections.Generic;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int>() { 6,3,4,6,6,2,2,2};
            Dictionary<int,int> freq= new Dictionary<int,int>();

            
            foreach(int number in numbers)
            {
                if (freq.ContainsKey(number))
                    freq[number]++;
                else
                    freq[number] = 1;
            }

            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No. of Occurrences: "+freq[number1]);
        }
    }
}
