using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/Проверка проекта/text.txt";
            int stroki = 0;
            int slova = 0;
            int sim = 0;
            


            //считаем количество символов
            using (StreamReader sr = new StreamReader(path))
            {
            
                while (sr.Peek() > -1)
                {
                    string str =sr.ReadLine();
                    sim += str.Length;
                }   
                Console.WriteLine("Количество символов в тексте {0}", sim);
            }

            //считаем количество строк
            using (StreamReader sr2 = new StreamReader(path))
            {
                while (sr2.Peek() > -1)
                {
                    sr2.ReadLine();
                    stroki++;
                }
                Console.WriteLine("Количество строк в тексте {0}", stroki);
            }

            //счиитаем количество слов
            using (StreamReader sr3 = new StreamReader(path))
            {
                string s = sr3.ReadToEnd();
                string[] m_slova = s.Split();
                foreach (string i in m_slova)
                {
                    if (i != "")
                    {
                        slova++;
                    }
                }
                Console.WriteLine("Количество слов в тексте {0}", slova);
            }
            Console.ReadKey();
        }
    }     
}
