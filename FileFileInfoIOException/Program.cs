using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fazer a instanciação do StreamReader de forma resumida
            // Ao invés de colocar 2 blocos using, vamos usar apenas 1 bloco using com a instanciação com classe File
           
            string path = @"D:\file1.txt";    // caminho de origem

            try
            {
                using (StreamReader sr = File.OpenText(path))         
                {
                    while (!sr.EndOfStream) // Ler o arquivo do inicio ao fim
                    {
                        string line = sr.ReadLine();     // Lendo uma linha de cada vez
                        Console.WriteLine(line);
                    }
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
