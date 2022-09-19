// //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// //Например, на выходе получается вот такой массив:
// //01 02 03 04       00 01 02 03
// //12 13 14 05       10 11 12 13
// //11 16 15 06       20 21 22 23
// //10 09 08 07       30 31 32 33 

// int[,] FillArray(int row, int colomns)
// {
//     int[,] array = new int[row,colomns];
//     int number = row * colomns;
//     int n = 1;
//     int i = 0;
//     int j = 0;
//     while (n <= number)
//     {
//       array[i,j] = n;
//       n++;
//       if (i <= j + 1 && i + j < colomns - 1)
//         j++;
//       else if (i < j && i + j >= row - 1)
//         i++;
//       else if (i >= j && i + j > colomns - 1)
//         j--;
//       else
//         i--;
//     }
//     return array;

// }

// void PrintArray(int[,] array)
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {   
//             Console.Write("| "+ array[i,j].ToString().PadLeft(2, '0') +" |");  
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите число строк и столбцов: ");
// int row = Convert.ToInt32(Console.ReadLine());
// int colomns = row;
// int[,] fullArray = FillArray(row,colomns);
// PrintArray(fullArray);


// //Задача 54: Задайте двумерный массив. Напишите программу, которая 
// //упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] FillArray(int row, int colomns) 
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

// int[,] SortRow(int[,] array)
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     int[] arrayRow = new int[colomns];
 
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < colomns; j++)
//             {   
//                 arrayRow[j] = array[i,j];
//             }
//                     Array.Sort(arrayRow);
//                     Array.Reverse(arrayRow);
//                     for (int j = 0; j < colomns; j++)
//                     {
//                         array[i,j] = arrayRow[j];
//                     }
//         }
//         return array;

    
// }

// void PrintArray(int[,] array)
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
// Console.WriteLine("Исходный массив");
// PrintArray(fullArray);
// int [,] sortArray = SortRow(fullArray);
// Console.WriteLine("Отсортированный массив");
// PrintArray(sortArray);



// // //Задача 56: Задайте прямоугольный двумерный массив. 
// // //Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] FillArray(int row, int colomns) 
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

// void FindMinSumRow(int[,] array)
// {   
//     int row = array.GetLength(0);
//     int colomns = array.GetLength(1);
//     int[] sumRowArray = new int[colomns];
//     for(int indRow = 0; indRow < row; indRow++)
//     {   
//         for (int i = 0; i < colomns; i++) 
//         {
//             sumRowArray[indRow] +=  array[indRow,i];
//         }
//     }
//     int min = sumRowArray[0];
//     int k = 0;
//     for (int i = 0; i < row; i++) 
//     {   
//         if(sumRowArray[i]<min) 
//         {
//             min = sumRowArray[i];
//             k = i;
//         }

//     }
//     Console.WriteLine($"Наименьшая сумма в {k} строке");
// }

// void PrintArray(int[,] array)
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
// Console.WriteLine("Введите число строк и столбцов:");
// int row = Convert.ToInt32(Console.ReadLine());
// int colomns = row;
// int[,] fullArray = FillArray(row,colomns);
// Console.WriteLine("Исходный массив");
// PrintArray(fullArray);
// FindMinSumRow(fullArray);



// // //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // //Например, даны 2 матрицы:
// // //2 4 | 3 4
// // //3 2 | 3 3
// // //Результирующая матрица будет: 
// // //18 20
// // //15 18

// int[,] MatrixOne (int[,] MatrixTwo, int[,] ThreeMatrix)
// {
//     int OneRow = MatrixTwo.GetLength(0);
//     int OneColomn = MatrixTwo.GetLength(1);
//     int TwoRow = ThreeMatrix.GetLength(0);
//     int TwoColomn = ThreeMatrix.GetLength(1);
//     int[,] resultMatrix = new int[OneRow,TwoColomn];
//     if (OneColomn ==  TwoRow)
//     {
//         for (int i = 0; i < OneRow; i++)
//         {
//             for (int j = 0; j < TwoColomn; j++)
//             {
//                 resultMatrix[i,j] = 0;
//                 for (int k=0; k < OneColomn; k++)
//                 {
//                     resultMatrix[i, j] += MatrixTwo[i, k] * ThreeMatrix[k, j];
//                 }
//             }
//         }
//         return resultMatrix;
//     }
//     else
//     {
//         Console.WriteLine("Такие матрицы не могут быть умножены");
//         return resultMatrix;
//     }
// }

// void PrintArray(int[,] array)
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

// int[,] matrixA = new int[,] 
// {
//     {2,4,7},
//     {3,2,1},
//     {2,5,9},
// };
// int[,] matrixB = new int[,] 
// {
//     {3,4,1},
//     {3,3,2},
//     {1,2,3},
// };
// Console.WriteLine("Умножим матрицу A и B (A * B)");
// Console.WriteLine("Матрица А выглядит так: ");
// PrintArray(matrixA);
// Console.WriteLine("Матрица B выглядит так: ");
// PrintArray(matrixB);
// int[,] result = MatrixOne(matrixA,matrixB);
// Console.WriteLine("Матрица их произведения:");
// PrintArray(result);


// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// //  двузначных чисел. Напишите программу, которая будет построчно
// //   выводить массив, добавляя индексы каждого элемента
// // Массив размером 2 x 2 x  


// int[] CreateArrayRandomizer(int min, int max)
// {
//     Random randomizer = new Random();
//     int size  = max - min;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         var num = randomizer.Next(min, max);
//         if (array.Contains(num)) i--;
//         else array[i] = num;
//     }
//     return array;
// }

// int[, ,] FillArray(int[, ,] emptyArray, int[] random)
// {
//     int x = emptyArray.GetLength(0);
//     int y = emptyArray.GetLength(1);
//     int z = emptyArray.GetLength(2);
//     int n = 0;
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {   
//             for (int k = 0; k < z; k++)
//             {
//                emptyArray[i,j,k] = random[n];
//                n++; 
//             }
//         }
//     }
//     return emptyArray;
// }

// void PrintArray(int[, ,] array)
// {   
//     int x = array.GetLength(0);
//     int y = array.GetLength(1);
//     int z = array.GetLength(2);
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {   
//             for (int k = 0; k < z; k++)
//             {
//                Console.Write(" | "+array[i,j,k]+$" |({j},{k},{i}) ");  
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Console.WriteLine("Введите размерность массива через запятую:");
// int[] sizeMatrix = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
// int x = sizeMatrix[0];
// int y = sizeMatrix[1];
// int z = sizeMatrix[2];
// int[, ,] emptyArray = new int[x,y,z];

// Console.WriteLine("Введите диапазон генерируемых чисел через дефис (10-100):");
// int[] rangeRand = Array.ConvertAll(Console.ReadLine().Split("-"), int.Parse);
// int min = rangeRand[0];
// int max = rangeRand[1]-1;

// if ((max - min) < x*y*z)
// {
//     Console.WriteLine("Диапазон чисел меньше чем, размерность массива");
// }
// else
// {
//     int[] arrayRandomizer = CreateArrayRandomizer(min, max);
//     int[, ,] fullArray = FillArray(emptyArray,arrayRandomizer);
//     PrintArray(fullArray);
// } 