// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int x = 7;
int y = 7;
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
        //Console.WriteLine("R " + newValue + "j = " + j);
        Console.WriteLine($"Right: " + "[" + i + ", " + (j + 1) + "] = " + newValue);
        newValue++;
    }
    else goto Down;
//PrintArray(matrix);
}

Down:
for( ; i + 1 < matrix.GetLength(0); i++)
{
    
    if(matrix[i + 1,j] == 0)
    {
        matrix[i + 1,j] = newValue;
        //Console.WriteLine("D " + newValue);
        Console.WriteLine("Down: " + "[" + (i + 1) + ", " + j + "] = " + newValue);
        newValue++;

    }
    else 
    {
        //Console.WriteLine("else");
        goto Left;
    }
}
// Console.WriteLine("[" + i + ", " + j + "] = " + matrix[i, j]);
// if(matrix[i,j] == 0)
//     {
//         matrix[i,j] = newValue;
//         //Console.WriteLine("D " + newValue);
//         newValue++;

//     }
//     else 
//     {
//         Console.WriteLine("else 2");
//         goto Left;
//     }

PrintArray(matrix);

Left:
for( ; j > 0; j--)
{
    
    if(matrix[i,j - 1] == 0)
    {
        matrix[i,j - 1] = newValue;
        Console.WriteLine("Left: " + "[" + i + ", " + (j - 1) + "] = " + newValue);
        newValue++;
    }
    else goto Up;
}
// Console.WriteLine("[" + i + ", " + j + "] = " + matrix[i, j]);
// if(matrix[i,j] == 0)
//     {
//         matrix[i,j] = newValue;
//         Console.WriteLine("L + " + newValue);
//         newValue++;
//     }
//     else goto End; //Up;


Up:
for( ; i > 0; i--)
{
    if(matrix[i - 1,j] == 0)
    {
        matrix[i - 1,j] = newValue;
        Console.WriteLine("Up: " + "[" + (i - 1) + ", " + j + "] = " + newValue);
        newValue++;
    }
    else goto Right;
}
// if(matrix[i,j] == 0)
//     {
//         matrix[i,j] = newValue;
//         Console.WriteLine("U + " + newValue);
//         newValue++;
//     }
//     else goto Right;

End:

PrintArray(matrix);
