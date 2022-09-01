// // Задача 25: Напишите цикл, который принимает на вход 
// //два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите число А");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int numB = Convert.ToInt32(Console.ReadLine());
// Summ(numA, numB);

// void Summ(int numA, int numB)
//         {
//             Console.WriteLine(Math.Pow(numA, numB));
//         }



// // Задача 27: Напишите программу, которая принимает 
// // на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите число");
// int numA = Convert.ToInt32(Console.ReadLine());
// int numB = 0;
// while (numA > 0)
//     {
//         numB = numB + numA % 10;
//         numA = numA / 10; 
//     }
//  Console.WriteLine(numB + " Сумма цифр в вашем числе ");

// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

int size = 8;
Random myRandom = new Random();
int[] array = new int [size];
CheckArray(array);

void CheckArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(8);
        Console.Write("{0} ", array[i]);
    }
    
}

 // Я наверное не правильно понял формулировку этой задачи?