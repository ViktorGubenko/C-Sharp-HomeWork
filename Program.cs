/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
} 

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Replace (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int m = 0; m < array.GetLength(1) - 1; m++)
      {
        if (array[i, m] < array[i, m + 1])
        {
          int temp = array[i, m + 1];
          array[i, m + 1] = array[i, m];
          array[i, m] = temp;
        }
      }
    }
  }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Replace(array);
Show2dArray(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
} 

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowsMinSum(int[,] array)
{
    int minSummLine = 0;
    int sumMinLine = 0;
    int summ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
            if (j == array.GetLength(1)-1)
            {
                if(i == 0)
                {
                    sumMinLine = summ;
                    minSummLine = 1;
                }
                else if (summ < sumMinLine)
                {
                    sumMinLine = summ;
                    summ = 0;
                    minSummLine = i + 1;
                }
                else
                {
                summ = 0;
                }
            }
        }
    }
    return minSummLine;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

System.Console.Write("Номер строки с наименьшей суммой: " + RowsMinSum(array));
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
} 

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplyMatrix(int[,] array, int[,] array2)
{
    int[,] generationMatrix = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) && i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) && j < array2.GetLength(1); j++)
        {
            generationMatrix[i, j] = array[i, j] * array2[i, j];
        }
    }
    return generationMatrix;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

int[,] array2 = CreateRandom2dArray(m, n, min, max);
Show2dArray(array2);

MultiplyMatrix(array, array2);
Show2dArray(MultiplyMatrix(array, array2));
*/

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)

int[,,] RandomArray3D(int[,,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

int[,,] IndexArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("-------------------------------");
    }
    return array;
}
int[,,] array = new int[2, 2, 2];
System.Console.WriteLine();
RandomArray3D(array);
IndexArray3D(array);
*/

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите размер массива ");


int size = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

Show2dArray(nums);