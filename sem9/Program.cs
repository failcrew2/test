//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""


// void PrintNumbers(int min, int max)
// {
//     if( min < max )
//     {
//         Console.Write($"{min},");
//         PrintNumbers(++min, max);
//     }
//     else if (min > max)
//     {
//         Console.Write($"{min},");
//         PrintNumbers(--min, max);
//     }
//     else Console.Write($"{min}");
// }
// Console.WriteLine("Введите числа Начала: ");
// int min = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число конца: ");
// int max = int.Parse(Console.ReadLine());
// PrintNumbers(min, max);



// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// //M = 1; N = 15 -> 120
// //M = 4; N = 8. -> 30


// int PrintSum(int min, int max)
// {
//     if( min < max )
//         {
//             Console.Write($"{min},");
//             return min + PrintSum(++min, max);
//         }
//     if (min > max)
//         {
//             Console.Write($"{min},");
//             return min + PrintSum(--min, max);
//         }
//     else 
//         {
//             Console.Write($"{min}");
//             return min;
//         }
// }
// Console.WriteLine("Введите первое число: ");
// int min = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе: ");
// int max = int.Parse(Console.ReadLine());

// int sumNumbers = PrintSum(min, max);
// Console.WriteLine($" - сумма этих элементов равна {sumNumbers}");


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");