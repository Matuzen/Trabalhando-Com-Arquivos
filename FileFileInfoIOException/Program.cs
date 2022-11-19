using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\file1.txt";    // caminho de origem

                using (FileStream fs = new FileStream(path, FileMode.Open))    // bloco using (instancia do FileStream(caminho, modo de abertura do arquivo))
                {
                    using (StreamReader sr = new StreamReader(fs))          // Cascatear mais de um bloco using, tudo aqui vai ser executado, quando esse bloco terminar esse recurso vai ser fechado (StreamReader)
                    {
                        while (!sr.EndOfStream) // Ler o arquivo do inicio ao fim
                        {
                            string line = sr.ReadLine();     // Lendo uma linha de cada vez
                            Console.WriteLine(line);
                        }
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
 