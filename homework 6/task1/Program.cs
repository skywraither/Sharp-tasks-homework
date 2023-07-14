
        Console.Write("Введите количество чисел: ");
        int m = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = 0; i < m; i++)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших нуля: " + count);


