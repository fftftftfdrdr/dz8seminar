// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3} ");
        }
       System.Console.WriteLine();      
    }
}
int FindSum(int[,] arr)
{
    int i = 0;
  int sum = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sum += arr[i,j];
  }
  return sum;
}

int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}




System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
FindSum(array);


int minSum = 0;
int sum = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumElements(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строка наименьшей суммой элементов ");

