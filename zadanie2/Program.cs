using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/Проверка проекта/log.txt";
            StreamWriter sw = new StreamWriter(path);
            Random random = new Random();
            int[] array = new int[10];
            int sum = 0;

            //создаем файл, если его нет
            if (!File.Exists(path))
            {
                File.Create(path);
            }


            //заполняем массив случайными числами
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-100,100) ;
                sw.Write("{0} ",array[i]);
            }
            sw.Close();

            StreamReader sr = new StreamReader(path);
            using (FileStream fs = File.OpenRead(path)) //не могу понять, почему не открывается файл, вроде все правильно написала
            {
                string s = sr.ReadToEnd();
                int[] mas = s.Split().
                Where(x => !string.IsNullOrWhiteSpace(x)).   //конвертируем string в масси
                Select(x => int.Parse(x)).ToArray();
                foreach (int i in mas)
                {
                    sum += i;
                }
                Console.WriteLine(sum);

            }
            Console.ReadKey();


        }
    }
}
