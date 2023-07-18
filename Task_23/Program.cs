{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до N:");
        Console.WriteLine("Число\tКуб");

        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i}\t{cube}");
        }
    }
}