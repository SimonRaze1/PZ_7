using System;

class Program
{
    static void Main()
    {
        int size = 4; // задаем размерность матрицы
        int[,] matrix = new int[size, size]
        {
            {1, -2, 3, 4},
            {5, 6, -7, 8},
            {-9, 10, 11, -12},
            {13, 14, 15, 16}
        };

        int countPositive = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (matrix[i, j] > 0) // проверяем, является ли элемент положительным
                {
                    countPositive++; // увеличиваем счетчик положительных элементов
                }
            }
        }

        Console.WriteLine("Количество положительных элементов, расположенных над главной диагональю: " + countPositive);
    }
}
