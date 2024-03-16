namespace Task2;
// Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл,
// рассчитайте сумму чисел в нем, ответ выведите на консоль.
class Program
{
    static void Main(string[] args)
    {
        string path = "Numbers.txt";//создаю в текущей папке, у меня мак
        Random random = new Random();
        using (StreamWriter sw = new StreamWriter(path, false)) 
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(0, 10));
            }
        }

        int S = 0;

        using (StreamReader sr = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                S+=Convert.ToInt32(sr.ReadLine());
            }
        }

        Console.WriteLine("Сумма чисел в файле {0}",S);
        Console.ReadKey();

    }
}

