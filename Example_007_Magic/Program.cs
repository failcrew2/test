



// SEM 7 DZ

//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] twoDimArray = new double[m, n];
// Random rnd = new Random();
// void PrintArray(double[,] matr)
//         { for (int i = 0; i < m; i++)
//         { for (int j = 0; j < n; j++)
//         { Console.Write($"{matr[i, j]} |");}
//         Console.WriteLine();}}

//         void FillArray(double[,] matr)
//         { for (int i = 0; i < m; i++)
//         { for (int j = 0; j < n; j++)
//         { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);


//// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
//// указание, что такого элемента нет.
//// Например, задан массив:
//// 1 4 7 2
//// 5 9 2 3
//// 8 4 2 4
//// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
    
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
//     }
    
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + "\t  ");
//             Console.WriteLine();
//     }
 
//  Console.WriteLine("Введите число");
//  int a = Convert.ToInt32(Console.ReadLine());
//  if (a>m && a>n)
//  Console.WriteLine(" такого числа в массиве нет ");
//  else
//  {
//  Console.WriteLine(" Ваше число " + a + " Присутвствует");
//  }



// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
double[] summ = new double[n];
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        array[i, j] = new Random().Next(10,100);
        System.Console.Write(array[i, j] + " | ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

RowArray(array);

foreach (double elem in summ)
{
    Console.WriteLine($" Среднее арифметическое " + elem/n);
}

void RowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             summ[i] += array[j, i];   
        }
    }
}
