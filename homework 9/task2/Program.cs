//  Задача 66: Задайте значения M и N. Напишите программу, 
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30


        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSumOfNaturalNumbers(m, n);

        Console.WriteLine("Сумма натуральных чисел от " + m + " до " + n + ": " + sum);
    

    static int CalculateSumOfNaturalNumbers(int m, int n)
    {
        if (n < m)
        {
            return 0;
        }

        return n + CalculateSumOfNaturalNumbers(m, n - 1);
    }
