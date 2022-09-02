// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] matrix = new int[2, 2, 2];

void PrintArray(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} " + "(" + i + "," + j + "," + k + ")  ");
            }
            Console.WriteLine();
        }
        
    }
}
void FillArray(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                matrix[i, j, k] = NewValue(matrix);
            }
        }
    }
}

int NewValue(int[,,] matr)
{
    NewValue:
    int value = new Random().Next(10, 100);
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                if(value == matr[i, j, k]) goto NewValue;
            }
        }
    }
    return value;
}

FillArray(matrix);
PrintArray(matrix);