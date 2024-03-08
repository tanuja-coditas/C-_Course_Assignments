using System;
using ClassLibrary3;

namespace GenericClasses
{
    internal class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main()
        {
            Database<int, string> database = new Database<int, string>();
            database.Add(1, "tanuja");
            database.Add(2, "shreya");
            database.Add(3, "akanksha");
            database.Add(4, "ajita");

            Console.WriteLine($"Count: {database.Count}");
            bool isValue = database.TryGetValue(3,out string value);
            if(isValue)
            {
                Console.WriteLine(value);
            }
            database.Remove(4);
            Console.WriteLine($"After Remove ,Count: {database.Count}");

            int a = 10, b = 20;
            Swap<int>(ref a,ref b);

            string name1 = "tanuja", name2 = "akanksha";
            Swap<string>(ref name1,ref name2);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(name1);
            Console.WriteLine(name2);



        }
    }
}
