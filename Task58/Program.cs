// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int i = 2;
int j = 2;
int k = 2;


int[,] matrix1 = new int[i, j];
int[,] matrix2 = new int[j, k];

matrix1[0, 0] = 2;
matrix1[0, 1] = 4;
matrix1[1, 0] = 3;
matrix1[1, 1] = 2;
matrix2[0, 0] = 3;
matrix2[0, 1] = 4;
matrix2[1, 0] = 3;
matrix2[1, 1] = 3;


int[,] resultMatrix = new int[i, k];

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

Console.WriteLine("Matrix 1: ");
PrintArray(matrix1);

Console.WriteLine("Matrix 2: ");
PrintArray(matrix2);

for(int i3 = 0; i3 < matrix1.GetLength(0); i3++)
{
    for(int j3 = 0; j3 < matrix2.GetLength(1); j3++)
    {
        for(int count = 0; count < matrix1.GetLength(1); count++)
        {
            resultMatrix[i3, j3] = resultMatrix[i3, j3] + matrix1[i3, count] * matrix2[count, j3];
        }
    }
}

Console.WriteLine("Matrix 1 * Matrix 2: ");
PrintArray(resultMatrix);