//namespace WhenAll
//{
//    internal class Program
//    {
//        class Sample
//        {

//        }
//        static async void Main(string[] args)
//        {

//          var tasks = new List<Task<int>>();
//            for (int ctr = 1; ctr <= 5; ctr++)
//            {
//                int baseValue = ctr;
//                tasks.Add(Task.Factory.StartNew(b => (int)b! * (int)b, baseValue));
//            }

//            var results = await Task.WhenAny(tasks);


//            Task<int> task1 = Task.Run(() => { return 1; });
//            Task task2 = Task.Run(() => { Console.WriteLine("hi"); });

//            var result= await Task.WhenAll(task1,task2);


//            //int sum = 0;
//            //for (int ctr = 0; ctr <= results.Length - 1; ctr++)
//            //{
//            //    var result = results[ctr];
//            //    Console.Write($"{result} {((ctr == results.Length - 1) ? "=" : "+")} ");
//            //    sum += result;
//            //}

//            //Console.WriteLine(sum);
//        }
//    }
//}


    using System.Collections.Generic;
    using System.Numerics;

public class Kata
{
    public static bool RobotWalk(int[] a)
    {
        //coding and coding..

        List<KeyValuePair<int, int>> coordinates = new List<KeyValuePair<int, int>>();
        int[] x = new int[4] { 0, 1, 0, -1 };
        int[] y = new int[4] { 1, 0, -1, 1 };
        int index = 0;
        int currX = 0, currY = 0;
        coordinates.Add(new KeyValuePair<int, int>(currX, currY));
        foreach (int steps in a)
        {
            if (index == 4)
                index = 0;
            for(int i=0;i<steps; i++)
            {
                currX += x[index];
                currY += y[index];
                coordinates.Add(new KeyValuePair<int, int>(currX, currY));
            }
            index++;
        }

        var count = coordinates.GroupBy(i => i).Where(g => g.Count() > 1).ToList().Count;

        Console.WriteLine(count);
       return count>=1 ?true:false;
       return false;
    }
    static void Main()
    {
        int[] a = new int[] { 6686, 5031, 6683, 5030, 6682, 5027, 6681, 5019, 6675, 5015, 6679, 5006, 6672, 5002, 6668 };
        Console.WriteLine(RobotWalk(new int[]{ 5589, 6023, 5579, 6019, 5573, 6010, 5567, 6003, 5559, 5999, 5558, 5991, 5553, 5986, 5548, 5977, 5543, 5968, 5540, 5964, 5537, 5962, 5530, 5958, 5521, 5953, 5520, 5943, 5517, 5934, 5507, 5932, 5501, 5931, 5494, 5924, 5490, 5920, 5487, 5912, 5479, 5903, 5476, 5901, 5472, 5897, 5463, 5890, 5461, 5886, 5452, 5883, 5449, 5879, 5445, 5875, 5442, 5868, 5436, 5867, 5427, 5860, 5422, 5850, 5417, 5841, 5415, 5836, 5407, 5828, 5401, 5826, 5394, 5821, 5387, 5817, 5377, 5811, 5376, 5805, 5369, 5801, 5361, 5792, 5360, 5785, 5350, 5782, 5343, 5778, 5338, 5771, 5330, 5769, 5320}));
    }
}