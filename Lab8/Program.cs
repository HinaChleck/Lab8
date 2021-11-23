using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
        {
            Console.WriteLine("Введите директорию");
            string pathinput=Console.ReadLine();
            string path=pathinput;
            string[] directories= Directory.GetDirectories(path);
            string[] files= Directory.GetFiles(path);
            Console.WriteLine("{0}:\n", path);

            foreach (string file in files)
            {
                Console.WriteLine(" {0}:", file);
            }

            foreach (string d in directories)
            {

                Console.WriteLine("  {0}:",d);
                string[] subfiles = Directory.GetFiles(d);
                foreach (string subfile in subfiles)
                {
                    string clearsubfile = subfile.Trim("d");
                    Console.WriteLine("    {0}",subfile); }
            }
                /*string subdirectories[]=Directory.GetDirectories(d);
                while (subdirectories.Length != 0)
                                    {
                    Console.WriteLine("{0}:"d);
                    string subsubdirectories[]=
                    foreach (strim s in subdirectories)
                    {
                        string subdirectories[] = Directory.GetDirectories(d);
                    }
                    }
                

            }*/
        Console.ReadKey();  
        }
    }
}
