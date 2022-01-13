using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleLab8_2
{
    class Lab8_2
    {
        static void Main(string[] args)
        {
            string path = @"Test\Test.txt";
            if (!File.Exists(path))
            {
                using (File.Create(path)) ;
            }
            Random random = new Random();
            int Sum = 0;
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-100, 100));
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    Sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел в файле = {0}", Sum);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
