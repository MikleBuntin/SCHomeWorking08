//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void FromMaxToMin(int[,] matrix)
{
    for(int stringIndex = 0; stringIndex < matrix.GetLength(0); stringIndex++)
    {
       
        for(int index = 0; index < matrix.GetLength(1); index++)
        {
            int i = index; 
            int indexMax = index;     
            
            for( ; i < matrix.GetLength(1); i++)
            {
                if(matrix[stringIndex, i] > matrix[stringIndex, indexMax])
                {
                    indexMax = i;
                }
                                
            }
            int temp = matrix[stringIndex, index];
            matrix[stringIndex, index] = matrix[stringIndex, indexMax];
            matrix[stringIndex, indexMax] = temp;

            
        }
        
    }
    }
FillArray(matrix);
Console.WriteLine("Original matrix: ");
PrintArray(matrix);

FromMaxToMin(matrix);
Console.WriteLine("Sorted matrix: ");
PrintArray(matrix);