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

            // Программа выводит:
            //1. перечень файлов, расположенных непосредственно в заданном каталоге
            //2. перечисление всех файлов каталога с разбивкой по их родительским папкам вне зависимости от уровня вложенности.

            Console.Write("Введите путь:  ");
            string path = Console.ReadLine();
            if (!Directory.Exists(@path)) Console.WriteLine("\nПуть не существует"); else
            {
                string[] rootfiles = Directory.GetFiles(@path);
                foreach (string rootfile in rootfiles)
                {
                    string rootFileName = new FileInfo(@rootfile).Name; ;
                    Console.WriteLine("  {0}", rootFileName);

                }
                
                string[] directories = Directory.GetDirectories(@path, "*", SearchOption.AllDirectories);
                foreach (string dir in directories)
                {
                    string dirName = new DirectoryInfo(@dir).Name; ;
                    Console.WriteLine("  {0}:", dirName);
                    string[] files = Directory.GetFiles(@dir);
                    foreach (string file in files)
                    {
                        string fileName = new FileInfo(@file).Name; ;
                        Console.WriteLine("      {0}", fileName);
                    }

                }
            }
            Console.ReadKey();  
        }
            
        
    }
}
