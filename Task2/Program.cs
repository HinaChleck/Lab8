using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
        {

            string path = @"Lab8_2.txt";
            if (File.Exists(path))   File.Delete(path);

            #region Создание и запись в файл массива случайных чисел
            string[] row=new string[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                row[i] = Convert.ToString(random.Next(0, 10));
                using (StreamWriter sw = new StreamWriter(path, true)) 
                { 
                    sw.Write("{0} ",row[i]); 
                }                
            }
            #endregion
            string line;
            using (StreamReader sr=new StreamReader(path))            
            {
                line =sr.ReadLine();
            }

            line= line.Trim();
            string[] readrow = line.Split();

            int sum = 0;
            for (int i = 0; i < readrow.Length; i++)
            {
                int number=Convert.ToInt32(readrow[i]);
                sum+=number;
            }
            Console.WriteLine("Сумма чисел в файле = {0}",sum);
            Console.WriteLine("\n(Создан файл: {0})", Path.GetFullPath(path));
            Console.ReadKey();  
        }
    }
}
