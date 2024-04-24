namespace SingletonClass
{
    internal class Program
    {
        class Singleton
        {
            private static Singleton instance;
            public string Name { get; set; }
            private Singleton()
            {
                Name = "tanuja";
            }

            public static Singleton GetInstance()
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                 return instance;
            }
        }
        static void Main(string[] args)
        {
           Singleton name = Singleton.GetInstance();
            Console.WriteLine(name.Name);
        }
    }
}
