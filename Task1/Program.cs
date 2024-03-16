namespace Task1;
//Выберите любую папку на своем компьютере, имеющую вложенные директории.
//Выведите на консоль ее содержимое и содержимое всех подкаталогов.
class Program
{
    static void Main(string[] args)
    {
        string path = Environment.CurrentDirectory;//текущая папка (Task1), у меня мак и работа с директориями как в уроке у меня не проходит:(
        string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    
     
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        Console.ReadKey();
    }
}

