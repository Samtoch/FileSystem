using System.IO;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USING C# Path Class");
            string tempDir = @"C:\temp";
            string fileName = "myText.txt";

            string content = "Hey There, This is the content of my file.";
            string fullQualifiedFileName = Path.Combine(tempDir, fileName);
            File.WriteAllText(fullQualifiedFileName, content);

            string fileExt = Path.GetExtension(fullQualifiedFileName);
            Console.WriteLine($"The extention name of {fullQualifiedFileName} is {fileExt}");

            string fileName_ = Path.GetFileName(fullQualifiedFileName);
            Console.WriteLine($"The File name of {fullQualifiedFileName} is {fileName_}");
            Console.ReadLine();
        }

        static void DirectoryClassManipulation()
        {
            Console.WriteLine("USING C# Directory Class");
            string tempDir = @"C:\temp";
            string tempSub_1Dir = @"C:\temp\sub1";
            string tempSub_2Dir = @"C:\temp\sub2\subsub";
            
            if (Directory.Exists(tempSub_2Dir))
            {
                //Directory.CreateDirectory(tempSub_2Dir);
                Directory.Delete(tempSub_2Dir, true);
                Console.WriteLine($"This directory {tempSub_2Dir} was deleted");
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public void ReadFileMethod()
        {
            string path = @"C:\temp"; //Path Name or Folder name or Directory Name
            string fileName1 = @"C:\temp\Contents.txt"; //Full Qualified File Name fqn
            string file = @"C:\temp\MyContents.txt";
            string[] lines;
            string text = "Great!... My name is Onyedika and I am a Software Developer. We are currently on File System";
            File.WriteAllText(file, text);

            List<string> lines1 = new List<string>() { "We are in the new Month", "This Month will be Blessed for us" };
            File.AppendAllLines(file, lines1);

            if (File.Exists(path))
            {
                Console.WriteLine("Yes the file exists");
                lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            File.Copy(fileName1, file);
            File.Delete(file);
            Console.WriteLine("Done");
        }
    }
}