using System.Collections.Concurrent;

namespace Dictionary2
{

    class Shared
    {
        static public ConcurrentDictionary<int, string> Names { get; set; }
        static Shared()
        {
            Names = new ConcurrentDictionary<int, string>();
        }
        
    }

    internal class Program
    {
         static void User1()
         {
                Shared.Names.TryAdd(1,"Tanuja");
                Shared.Names.TryAdd(2, "Tanuja");
                Console.WriteLine(Shared.Names[2]);
                Shared.Names.TryRemove(new KeyValuePair<int, string>(1,"Tanuja"));
         }

    static void User2()
        {
            Shared.Names.TryRemove(new KeyValuePair<int, string>(1, "Tanuja"));
            Shared.Names.TryAdd(2, "Shreya");

        }
    static void User3()
        {
            Shared.Names.TryAdd(3, "Ajita");
            Console.WriteLine(Shared.Names[1]);
            Console.WriteLine(Shared.Names[2]);
            Console.WriteLine(Shared.Names[3]);

        }
    static void Main(string[] args)
        {

            Thread thread1 = new Thread(new ThreadStart(User1));
            Thread thread2 = new Thread(new ThreadStart(User2));
            Thread thread3= new Thread(new ThreadStart(User3));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Completed");
        }
    }
}
