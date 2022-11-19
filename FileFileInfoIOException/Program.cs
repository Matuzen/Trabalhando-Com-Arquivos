﻿using System;
using System.Collections.Generic;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\# Aulas de Programação\My Folder";

            try
            {
                Console.WriteLine("DirectorySeparatorChar" + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator" + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName" + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName" + Path.GetFileName(path));
                Console.WriteLine("GetFileNameWithoutExtension" + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetExtension" + Path.GetExtension(path));
                Console.WriteLine("GetFullPath" + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath" + Path.GetTempPath());
            }

            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
