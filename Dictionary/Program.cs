namespace Dictionary
{


    class Shared
    {
        static public  Dictionary<int, char> alphabets = new Dictionary<int, char>();
        static public object lockObject = new object(); 
    }
    internal class Program
    {


        static void AddItem()
        {
            for(int i='A';i<='Z';i++)
            {
                lock(Shared.lockObject)
                {
                    Shared.alphabets.Add(i, (char)i);
                }
               
            }
        }

        static void RemoveItem()
        {
            for (int i = 'A'; i <= 'Z'; i++)
            {
                lock (Shared.lockObject)
                {
                    char a = Shared.alphabets[i];
                    Console.WriteLine(a);
                }
               
            }
        }
        static void Main(string[] args)
        {
           
            ThreadStart threadStart1 = new ThreadStart(AddItem);
            ThreadStart threadStart2 = new ThreadStart(RemoveItem);

            Thread thread1 = new Thread(threadStart1);
            Thread thread2 = new Thread(threadStart2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Completed...");

        }
    }
}
