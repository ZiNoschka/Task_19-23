﻿{
   Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int digit1 = number / 10000;
        int digit2 = (number / 1000) % 10;
        int digit3 = (number / 100) % 10;
        int digit4 = (number / 10) % 10;
        int digit5 = number % 10;

        if (digit1 == digit5 && digit2 == digit4)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    
}