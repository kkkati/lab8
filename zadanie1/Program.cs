using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/Проверка проекта";
            string searchPattern = "*";
            DirectoryInfo direct = new DirectoryInfo(path);
            DirectoryInfo[] dir= direct.GetDirectories(searchPattern,SearchOption.AllDirectories);


            foreach (var papka in dir)
            {
                Console.WriteLine(papka.Name);
            }
            foreach (var file in direct.GetFiles(searchPattern,SearchOption.AllDirectories))
            {
                Console.WriteLine(file.Name);
            }


            Console.ReadKey();
        }
    }
}
