// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int x = 4;
int y = 4;
int[,] matrix = new int[x, y];

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

int newValue = 1;
int i = 0;
int j = 0;
matrix[i,j] = newValue;
newValue++;

Right: 
if(newValue > x * y) goto End;
for( ; j + 1 < matrix.GetLength(1); j++)
{
    if(matrix[i,j + 1] == 0)
    {
        matrix[i,j + 1] = newValue;
        newValue++;
    }
    else goto Down;
}

Down:
for( ; i + 1 < matrix.GetLength(0); i++)
{
    if(matrix[i + 1,j] == 0)
    {
        matrix[i + 1,j] = newValue;
        newValue++;
    }
    else goto Left;
}

Left:
for( ; j > 0; j--)
{
    if(matrix[i,j - 1] == 0)
    {
        matrix[i,j - 1] = newValue;
        newValue++;
    }
    else goto Up;
}

Up:
for( ; i > 0; i--)
{
    if(matrix[i - 1,j] == 0)
    {
        matrix[i - 1,j] = newValue;
        newValue++;
    }
    else goto Right;
}

End:
PrintArray(matrix);
