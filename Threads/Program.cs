using System.Threading;

namespace Threads
{

    class SharedResource
    {
        public static string message = "This is Shared one";
        public static object lockObject = new object();
    }

    internal class Program
    {

        static void TimerCallback(object state)
        {
            
            Thread thread = (Thread)state;
            thread.Interrupt();
        }

        static void PrintNumbers()
        {
            //Console.WriteLine("Thread1 Running..");
            for(int i=1;i<=10;i++)
            {
                Monitor.Enter(SharedResource.lockObject);
                Console.WriteLine("Thread 1 :{0}",SharedResource.message);
                Console.WriteLine("Number Thread: {0}",i);
                Thread.Sleep(1000);
                Monitor.Exit(SharedResource.lockObject);
            }
           // Console.WriteLine(" Thread1 Compleled");
        }
        static void PrintAlphabets()
        {
            //Console.WriteLine("Thread2 Running..");
            for (int j='A';j<='Z';j++)
            {
                lock (SharedResource.lockObject)
                {
                    Console.Write("Thread 2: {0}",SharedResource.message);
                    Console.WriteLine("Alphabet Thread:{0}", (char)j);
                    Thread.Sleep(500);
                }
                
            }
           // Console.WriteLine(" Thread2 Compleled");
        }
        static void PrintRandomNumbers()
        {
           // Console.WriteLine("Thread3 Running..");
            try
            {
            
               Random random = new Random();
                DateTime startTime = DateTime.Now;
                while (Thread.CurrentThread.IsAlive)
                {
                    lock(SharedResource.lockObject) {
                        Console.Write("Thread 3: {0}",SharedResource.message);
                        int randomNumber = random.Next(0, 100);
                        Console.WriteLine($"Random Number Thread: {randomNumber}");
                        Thread.Sleep(50);
                    }
                    
               }
                
            }
            catch(ThreadInterruptedException)
            {
                Console.WriteLine("5 seconds are completed");
            }
        }
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            ThreadStart threadStart1 = new ThreadStart(PrintNumbers);

            ThreadStart threadStart2 =  PrintAlphabets;

            ThreadStart threadStart3 = new ThreadStart(PrintRandomNumbers);


            Thread thread1 = new Thread(threadStart1);
            Thread thread2 = new Thread(threadStart2);
            Thread thread3 = new Thread(threadStart3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Timer timer = new Timer(TimerCallback, thread3, 5000, Timeout.Infinite);


            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Main Thread Compleled");



        }
    }
}
