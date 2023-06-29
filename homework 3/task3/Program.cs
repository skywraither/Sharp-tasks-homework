        Console.WriteLine("Введите число N:");
        int N = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");

        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(i + " ^ 3 = " + cube);
        }