//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07





        int n = 4; // Размерность массива (количество строк и столбцов)
        int[,] array = new int[n, n];
        int value = 1; // Значение для заполнения массива

        int topRow = 0;
        int bottomRow = n - 1;
        int leftColumn = 0;
        int rightColumn = n - 1;

        while (value <= n * n)
        {
            // Заполнение верхней строки
            for (int j = leftColumn; j <= rightColumn; j++)
            {
                array[topRow, j] = value++;
            }
            topRow++;

            // Заполнение правого столбца
            for (int i = topRow; i <= bottomRow; i++)
            {
                array[i, rightColumn] = value++;
            }
            rightColumn--;

            // Заполнение нижней строки (справа налево)
            for (int j = rightColumn; j >= leftColumn; j--)
            {
                array[bottomRow, j] = value++;
            }
            bottomRow--;

            // Заполнение левого столбца (снизу вверх)
            for (int i = bottomRow; i >= topRow; i--)
            {
                array[i, leftColumn] = value++;
            }
            leftColumn++;
        }

        // Вывод массива на экран
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }
    
