// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);

int[,] matrix = new int[m, n];

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($"  |{matr[i, j]}|  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = new Random().Next(0, 10);
        }
    }
}

int GetMinStringIndex(int[,] matr)
{
    int minSumm = 0;
    for(int j = 0; j < matr.GetLength(1); j++)
        {
          minSumm = minSumm + matr[0, j];
        }

    int minIndex = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        int summ = 0;
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          summ = summ + matr[i, j];
        }

    if(summ < minSumm)
    {
        minSumm = summ;
        minIndex = i;
    }
    }
    return minIndex;
}

FillArray(matrix);
Console.WriteLine("Matrix: ");
PrintArray(matrix);

Console.WriteLine("Строка с наименьшей суммой элементов имеет индекс: " + GetMinStringIndex(matrix));