//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)






        int[,,] array = new int[2, 2, 2];
        bool[] used = new bool[100];

        Random random = new Random();

        int count = 0;
        while (count < 8) // 2x2x2 = 8 элементов в массиве
        {
            int number = random.Next(10, 100);
            if (!used[number])
            {
                used[number] = true;
                array[count / 4, (count / 2) % 2, count % 2] = number;
                count++;
            }
        }

        // Вывод трехмерного массива с индексами
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    
