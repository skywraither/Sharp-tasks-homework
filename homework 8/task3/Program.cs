//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18






        // Задаем первую матрицу
        int[,] matrix1 = {
            { 2, 4 },
            { 3, 2 }
        };

        // Задаем вторую матрицу
        int[,] matrix2 = {
            { 3, 4 },
            { 3, 3 }
        };

        // Проверяем возможность умножения матриц
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Матрицы нельзя перемножить, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return;
        }

        // Создаем результирующую матрицу
        int[,] resultMatrix = new int[rows1, cols2];

        // Находим произведение матриц
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        // Вывод результирующей матрицы на экран
        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    