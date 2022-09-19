// /*
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// */

// int[] array1 = {-4, -8, 8, 2};

// for(int i = 0; i < array1.Length; i++)
// {
//     array1[i] = array1[i] * (-1);
// }

// Console.WriteLine("[{0}]", string.Join(", ", array1));



// /*
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// */

// int[] array2 = { 6, 7, 5, 9, 3, 1 };
// System.Console.WriteLine("Введите искомое число:");
// int x = Convert.ToInt32(Console.ReadLine());

// if (array2.Contains(x))
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// // // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // // [5, 18, 123, 6, 2] -> 1
// // // [1, 2, 3, 6, 2] -> 0
// // // [10, 11, 12, 13, 14] -> 5

// int[] array3 = new int[123]; // Код заполнения массива
// for(int i=0; i<array3.Length; i++)
// {
// int number = new Random().Next(0,100);
// array3[i] = number;
// Console.Write(array3[i] + ", ");
// }

// System.Console.WriteLine();

// int count = 0; //Переменная счетчика

// foreach(int a in array3) //Пробежались по элементам массива 
// {

//     if (a > 9 && a < 100) //проверили диапазон
//     count ++;
// }
// System.Console.WriteLine(count);

//Console.WriteLine("[{0}]", string.Join(", ", array3));


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array4 = new int[6];
// int[] array5 = new int[array4.Length / 2];

// for (int i = 0; i < array4.Length; i++)
// {
//     int number = new Random().Next(0, 100);
//     array4[i] = number;
//     Console.Write(array4[i] + ", ");
// }

// //int multiply = 1;

// for (int i = 0, j = array4.Length - 1; i < array4.Length / 2; i++, j--)
// {
//     array5[i] = array4[i] * array4[j];

// }
// Console.WriteLine("[{0}]", string.Join(", ", array5));

// 1) использовать динамические массивы и задавать ему размер внутри программы
//int[] array = new int[7];

// 2) Зарандомить массив в диапазоне выбранном пользователем 
// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     System.Console.Write(array[i] + ", ");
// }

// 3) Вывести массив на экран 
// 4) Найти минимальный и максимальный элементы

// Кто успеет может побаловаться Сортировкой 
// Нужно отсортировать массив 
// 1) использовать динамические массивы и задавать ему размер внутри программы 
// 2) Зарандомить массив в диапазоне выбранном пользователеем 
// 3) Вывести массив на экран 
// 4) Отсортировать массив 
// 5) вывести массив на экран


//  int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

// Пишите тут.


// string answer;

//  Console.WriteLine(answer = (num % 2 == 0) ? "EVEN" : "ODD");

// int x = 5;

// int y = 3;

// int z = x < y ? (x + y) : (x - y);

// Console.WriteLine(z);




// Создание, заполнение и вывод в консоль массива, массив не сохраняется

// int[] FillAndPrintArray()
// {
//     System.Console.Write("Задайте размер массива: ");
//     int size = Int32.Parse(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(10);
//     }
//     for (int j = 0; j < size; j++)
//     {
//         if (j == 0) System.Console.Write($"[{array[j]}, ");
//         else if (j < size - 1) System.Console.Write($"{array[j]}, ");
//         else System.Console.Write($"{array[j]}]");
//     }
//     System.Console.WriteLine();
//     return array;
// }




// int min = -5;
// int max = -156;
// int diff = Math.Abs(max - min);
// System.Console.WriteLine(diff);

/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

// int m = 3, n = 4;

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine(array.GetLength(0));


/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// int m = 3, n = 4;

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// SquareArray(array);

// void SquareArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }


/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

// int m = 5, n = 5;

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// DiagArray(array);

// void DiagArray(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             if (i == j) sum += array[i, j];

//         }

//     }
//     System.Console.WriteLine("Сумма элементов по диагонали равна: " + sum);
// }

// Задача дополнительная 
// Задайте двумерный массив. Найдите сумму элементов, находящихся ниже главной диагонали 

// int m = 5, n = 5;

// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i, j] + " ");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// DiagArray(array);

// void DiagArray(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i > j) sum += array[i,j];
//         }            
//     }
//     System.Console.WriteLine("Сумма элементов под главной диагональю равна: " + sum);
// }

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// System.Console.Write("Задайте размер двумерного массива через пробел: ");
// string[] sizeOfMatrix = InputFromConsole();
// double[,] massive = CreateMatrix(sizeOfMatrix);
// double[,] newMassive = SwapRow(massive);
// PrintArray(newMassive);

// string[] InputFromConsole() // Функция принимает данные из консоли и сохраняет в массив.
// {
//     string input = Console.ReadLine();
//     string[] splitArray = input.Split(' ');
//     return splitArray;
// }

// double[,] CreateMatrix(string[] array) // Создаем, заполняем и выводим в консоль двумерный массив размером заданным пользователем.
// {
//     System.Console.WriteLine();
//     int rows = int.Parse(array[0]);
//     int columns = int.Parse(array[1]);
//     double[,] newArray = new double[rows, columns];
//     System.Console.WriteLine("Ваш новый массив: ");

//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = new Random().Next(10, 100);
//             System.Console.Write($"{newArray[i, j]}     ");
//         }
//         System.Console.WriteLine();
//     }
//     return newArray;
// }


// double[,] SwapRow(double[,] array)
// {
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     double[] tmp_row = new double[colomns];
//     for (int i = 0; i < colomns; i++)
//     {
//         tmp_row[i] = array[0, i];
//         array[0, i] = array[row - 1, i];
//         array[row - 1, i] = tmp_row[i];
//     }
//     return array;
// }

// void PrintArray(double[,] array)
// {
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             Console.Write("| " + array[i, j] + " |");
//         }
//         Console.WriteLine();
//     }
// }
    
    
    
                                //////SEMINAR 8



// Задача 53: Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

// int[,] FillArray(int row, int colomns)   // <------ 
// {
//     int[,] array = new int[row,colomns];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//     return array;
// }

// int[,] SwapRow(int[,] array) //<--------Метод меняет местами первый элемент массива с последним
// {
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     int[] tmp_row = new int[colomns];
//     for (int i = 0; i < colomns; i++)
//     {
//         tmp_row[i] = array[0,i];
//         array[0,i] = array[row-1,i];
//         array[row-1,i] = tmp_row[i] ;
//     }
//     return array;
// }
// void PrintArray(int[,] array) //<------Печатает массив
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {   
//             Console.Write("| "+array[i,j]+" |");  
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите число строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов: ");
// int colomns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Исходный массив");
// int[,] fullArray = FillArray(row,colomns);  //<------название метода или функции
// PrintArray(fullArray); //<------название метода или функции
// Console.WriteLine("Итоговый массив");
// int[,] swapRowArray = SwapRow(fullArray); //<------название метода или функции
// PrintArray(swapRowArray); //<------название метода или функции





//Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// int[,] FillArray(int row, int colomns)   // <------ 
// {
//     int[,] array = new int[row,colomns];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//     return array;
// }

// void CounterBook(int[,] array)
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
 
//     for (int checkItem = 0; checkItem<10; checkItem++)
//     {   int counter = 0;
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < colomns; j++)
//             {   
//                 int number = array[i,j];
//                 if(number == checkItem)
//                 {
//                     counter += 1; 
//                 }
//             }
//         }
//         if (counter != 0) Console.WriteLine($"Элемент {checkItem} находится повторяется {counter} раз");
//     }
// }

// void PrintArray(int[,] array) //<------Печатает массив
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {   
//             Console.Write("| "+array[i,j]+" |");  
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите число строк :");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов :");
// int colomns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Исходный массив");
// int[,] fullArray = FillArray(row,colomns);
// PrintArray(fullArray);
// CounterBook(fullArray);


////Код от препода

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);
 
int[,] GetArray(int m, int n, int min, int max)
{
   int[,] result = new int[m, n];
   for (int i = 0; i < m; i++)
   {
       for (int j = 0; j < n; j++)
       {
           result[i, j] = new Random().Next(min, max + 1);
       }
 
   }
   return result;
}
 
int[] GetRowArray(int[,] inArray)
{
   int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
   int index=0;
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
           result[index] = inArray[i,j];
           index++;
       }
   }
   return result;
}
 
void SortArray(int[] inArray)
{
   for (int i = 0; i < inArray.Length; i++)
   {
       for (int j = i+1; j < inArray.Length; j++)
       {
           if(inArray[i]>inArray[j])
           {
               int k=inArray[i];
               inArray[i]=inArray[j];
               inArray[j]=k;
           }
       }
   }
}
 
 
void PrintArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
           Console.Write($"{inArray[i, j]} ");
       }
       Console.WriteLine();
   }
}
 
void PrintData(int[] inArray)
{
   int el=inArray[0];
   int count = 1;
   for (int i = 1; i < inArray.Length; i++)
   {
       if(inArray[i]!=el)
       {
           Console.WriteLine($"{el} встречается {count}");
           el=inArray[i];
           count=1;
       }
       else
       {
           count++;
       }
   }
   Console.WriteLine($"{el} встречается {count}");
}

