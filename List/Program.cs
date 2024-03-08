using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<int> numbers = new List<int>();
             numbers.Capacity = 3;
             Console.WriteLine(numbers.Count);
             Console.WriteLine(numbers.Capacity);
             numbers.Add(1);
             numbers.Add(2);
             numbers.Add(3);
             numbers.Add(4);
             numbers.Insert(2, 7);
             Console.WriteLine(numbers.Count);
             Console.WriteLine(numbers.Capacity);
            



            /* Dictionary<int,int> dictionary = new Dictionary<int,int>();

             dictionary.Add(1, 2);
             dictionary.Add(2, 3);
             dictionary.Add(3, 4);
             bool isRemoved = dictionary.Remove(4);
             Console.Write(isRemoved);*/

            SortedList<int, string> names = new SortedList<int, string>();

            names[1] = "Tanuja";
            names.Add(2, "Ajita");
            Console.WriteLine(names.Count);
            var keys = names.Keys;
            foreach ( var key in keys )
            {
                Console.WriteLine(key);
            }
            Console.WriteLine(names.IndexOfKey(2));
            Console.WriteLine(names.IndexOfValue("Ajita"));



        }
    }
}
