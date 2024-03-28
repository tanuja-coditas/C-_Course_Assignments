using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentDictionary
{
    class Shared
    {
        static public ConcurrentDictionary<int, char> alphabets = new ConcurrentDictionary<int, char>();
        static public object lockObject = new object();
    }

    internal class Program
    {
        static void AddItem()
        {
            for (int i = 'A'; i <= 'Z'; i++)
            {
                lock(Shared.lockObject)
                {
                    Shared.alphabets.TryAdd(i, (char)i);
                }
            }
        }

        static void RemoveItem()
        {
            Thread.Sleep(100);
            for (int i = 'A'; i <= 'Z'; i++)
            {
               lock(Shared.lockObject)
                {
                    char a = Shared.alphabets[i];
                    Console.WriteLine(a); 
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(RemoveItem));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Completed...");
        }
    }
}
