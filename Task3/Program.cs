using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Task3;
//Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу,
//которая выводит статистику по файлу - количество символов, строк и слов в тексте.
class Program
{
    static void Main(string[] args)
    {
        string path = "Text.txt";
        int str = 0;
        int symb = 0;
        int words = 0;
        

        using (StreamReader sr1 = new StreamReader(path))
        {
            while (sr1.ReadLine() != null)
            {
                str++;
            }
        }


        using (StreamReader sr2 = new StreamReader(path))
        {
            while (sr2.Read() != -1)
            {
                symb++;

            }
        }

        using (StreamReader sr3 = new StreamReader(path))
        {
            words = Regex.Matches(sr3.ReadToEnd(), @"\b\w+\b").Count;
        }

       

        Console.WriteLine("Количество строк {0}", str);
                Console.WriteLine("Количество символов {0}", symb);
                Console.WriteLine("Количество слов {0}", words);
                Console.ReadKey();

            }


        }
  

