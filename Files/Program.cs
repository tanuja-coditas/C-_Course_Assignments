using System.Security.Cryptography;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 'File' Class
            string folder = "C:\\Users\\Coditas-Admin\\Desktop\\Files";
            //string filePath = @"C:\Users\Coditas-Admin\Desktop\Files\fileEx.txt";
            //File.Create(filePath).Close();
            //Console.WriteLine("File created");

            //Console.WriteLine(File.Exists(filePath));
            //File.Open(filePath, FileMode.Append, FileAccess.Write).Close();
            //File.WriteAllText(filePath, "This is sample file");
            //File.WriteAllText(filePath, "This is next Line");

            //string[] names = new string[4] { "tanuja", "shreya", "akanksha", "ajita" };
            //File.WriteAllLines(filePath, names);

            //string[] newNames = File.ReadAllLines(filePath);

            //foreach(string name in newNames)
            //{
            //    Console.WriteLine(name);
            //}

            //File.Copy(filePath, @"C:\Users\Coditas-Admin\Desktop\Files\fileEx1.txt");
            //File.Delete(filePath);
            //File.Move(@"C:\Users\Coditas-Admin\Desktop\Files\fileEx1.txt", filePath);



            // 'FileInfo' class

            //string filePath = folder + @"\fileInfoEx.txt";

            //FileInfo fileInfo = new FileInfo(filePath);
            //fileInfo.Create().Close();

            //File.WriteAllText(filePath, "This is FileInfo Example");

            //Console.WriteLine(fileInfo.FullName);
            //Console.WriteLine(fileInfo.Name);
            //Console.WriteLine(fileInfo.CreationTime);
            //Console.WriteLine(fileInfo.LastAccessTime);
            //Console.WriteLine(fileInfo.LastWriteTime);
            //Console.WriteLine(fileInfo.Extension);
            //Console.WriteLine(fileInfo.Length);


            //'File Stream' Class

            //string filePath = folder + @"\fileStreamEx.txt";
            //FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            ////string line = "This is File Stream Example.";

            ////byte[] buffer = System.Text.Encoding.ASCII.GetBytes(line);

            ////fileStream.Write(buffer, 0, buffer.Length);

            ////line = "This is Next Line";

            ////buffer = System.Text.Encoding.ASCII.GetBytes(line);

            ////fileStream.Write(buffer, 0, buffer.Length);

            //byte[] bytes = new byte[10];
            //int isRead = fileStream.Read(bytes, 0,bytes.Length);
            //while(isRead > 0)
            //{
            //    string line = System.Text.Encoding.ASCII.GetString(bytes);
            //    Console.WriteLine(line);
            //    isRead = fileStream.Read(bytes, 0, 10);
            //}

            //fileStream.Close();


            //FileStream file= new FileStream(folder+@"\fileStreamEx.txt",FileMode.Open,FileAccess.Write);

            //using(StreamWriter writer = new StreamWriter(file))
            //{
            //    writer.WriteLine("This is example of stream writer");
            //    writer.WriteLine("This is next Line");

            //}

            //FileStream file1 = new FileStream(folder + @"\fileStreamEx.txt", FileMode.Open, FileAccess.Read);
            //using (StreamReader reader = new StreamReader(file1))
            //{
            //    string line;
            //    do
            //    {
            //        line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    } while (line!=null);
            //}



            

        }
    }
}
