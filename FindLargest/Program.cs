using System;
using System.Collections.Generic;
namespace FindLargest
{
    internal class Program
    {
        static List<int> FindLargest(List<List<int>> collections)
        {
            List<int> result=new List<int>();
            foreach(List<int> list in collections)
            {
                int mx = int.MinValue;
                foreach(int number in list)
                {
                    if (number > mx)
                        mx = number;
                }
                result.Add(mx);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> result=FindLargest(new List<List<int>>() {
                new List<int>( ) { 67, 100, 23 },
                new List<int>( ) { 80, 99, 750, 99 },
                 new List<int>( ) { 888, 333, 9898 } });

            foreach(int item in result)
            {
                Console.Write(item + " ");
            }

        }
    }
}
