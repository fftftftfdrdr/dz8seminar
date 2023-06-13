﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();

int[,,] array3D = 
{
      {
        {66,25},
        {34,41}
      },
      {
        {27,90},
        {26,55}
      }
};
PrintArray(array3D);

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
    {
      Console.Write($"{array3D[i,j,k]}=X({i}) Y({j}) Z({k});  ");
    
      Console.WriteLine();
    }
    Console.WriteLine();
    }
  }
}