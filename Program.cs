// Задача 54:
// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.



Console.Clear();
Console.WriteLine("");
Console.WriteLine("\t Задача 54");
int[,] array = GetArray(6, 6, 0, 9);
PrintArray(array);
int[,] ordererArray = OrderedArray(array);
PrintArray(ordererArray);


int[,] OrderedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSize = array.GetLength(1);
        while (currentSize > 1)
        {
            for (int j = 1; j < currentSize; j++)
            {
                int minValue = array[i, j - 1];
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                }
                else
                {
                    minValue = array[i, j - 1];
                    array[i, j - 1] = array[i, j];
                    array[i, j] = minValue;

                }
            }
            currentSize--;
        }

    }
    return array;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; \t");
        }
        Console.SetCursorPosition(Console.CursorLeft - 7, Console.CursorTop);
        Console.WriteLine(" ]");
    }
    Console.WriteLine("");
}