﻿//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2




        // Задаем двумерный массив
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0); // Количество строк
        int columns = array.GetLength(1); // Количество столбцов

        // Упорядочивание элементов каждой строки по убыванию
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int k = 0; k < columns - j - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        // Обмен элементов для упорядочивания по убыванию
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }

        // Вывод упорядоченного массива на экран
        Console.WriteLine("Упорядоченный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    