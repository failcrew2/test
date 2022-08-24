// //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Какой сегодня день недели?");
// int weekday = Convert.ToInt32(Console.ReadLine());

//     if (weekday <= 7)
//     {
//     if (weekday == 1)
//     Console.Write("Сегодня понедельник - будний день. "); 
//         else if (weekday == 2)
//             Console.Write("Сегодня Вторник - будний день");
//         else if    (weekday == 3)
//             Console.Write("Сегодня Среда - будний день");
//         else if    (weekday == 4)  
//             Console.Write("Сегодня Четверг - будний день");
//         else if    (weekday == 5)       
//             Console.Write("Сегодня Пятница - будний день");
//         else if    (weekday == 6) 
//             Console.Write("Сегодня Суббота - Выходной день");
//         else if    (weekday == 7) 
//             Console.Write("Сегодня Воскресение - Выходной день");    
//        }
//     else
//         Console.Write(" Дней в неделе всего 7 ;) ");

    

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


//     Console.Write(" Введите трехзначное число ");
// int NumberA = Convert.ToInt32(Console.ReadLine());
// int NumberB = 0;

//   if (100 <= NumberA && NumberA <= 999 )
//     {
//         NumberB = NumberA % 10;
//         Console.WriteLine(NumberB + " Последняя цифра числа ");
//     }
//   else
//         {
//         Console.WriteLine("Вы ввели не трехзначное число"); 
//         }




// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine(" Введите трехзначное число ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = 0;

  if (100 <= NumberA && NumberA <= 999)
    {
    NumberB = NumberA % 100 / 10;
    Console.WriteLine(NumberB + " Вторая цифра числа ");
    }
else
{
  Console.WriteLine(" Вы ввели не трех значное число");
}

//  // Это второй вариант решения задачи которая выше)) Но он меня не утроил т.к это работает с двухзначными. 

// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа "+stringNumber[1]);