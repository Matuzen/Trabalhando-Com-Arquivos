using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\file1.txt";
            string targetPath = @"D:\file2.txt";
            
            try
            {
                // Ler todo o conteúdo do file1
                string[] lines = File.ReadAllLines(sourcePath);

                // Instanciar o StreamWriter para escrever no arquivo de saída
                using (StreamWriter sw = File.AppendText(targetPath))
                // AppendText vai abrir o arquivo para escrita e tudo que for mandado a escrever
                // vai ser mandado no final do arquivo (Append significa concatenação, ou seja vai ser acrescentado ao final)
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); // escrever essa string line no arquivo sw convertido em letra maiúscula
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
