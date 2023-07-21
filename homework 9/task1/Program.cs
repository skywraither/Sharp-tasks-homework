//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//  N = 5 -> "5, 4, 3, 2, 1"
//  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"        
        
        
        
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Результат: ");
        PrintNumbersFromNTo1(n);

    static void PrintNumbersFromNTo1(int n)
    {
        if (n > 0)
        {
            Console.Write(n + ", ");
            PrintNumbersFromNTo1(n - 1);
        }
        else if (n == 0)
        {
            Console.Write(n);
        }
    }