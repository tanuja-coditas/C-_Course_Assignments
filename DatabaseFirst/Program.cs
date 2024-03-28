using DatabaseFirst.Models;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SampleContext())
            {
                var data = dbContext.Students.ToList();

                foreach (var item in data)
                {
                    Console.WriteLine($"{item.Id}: {item.Name}");
                }
            }
        }
    }
}
