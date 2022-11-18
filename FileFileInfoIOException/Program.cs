using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\file1.txt";    // caminho de origem
           
            StreamReader sr = null;
            try
            {

                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
              
            }
        }
    }
}
 