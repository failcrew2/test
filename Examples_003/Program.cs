// Задача номер 15

//     Console.WriteLine("Какой сегодня по счету  день недели?");
//     int weekday = Convert.ToInt32(Console.ReadLine());

//     if (weekday <= 7)
//     {
//     if (weekday == 1)
//         Console.WriteLine("Сегодня будний день. Понедельник");
//         else  if(weekday == 2)
//         Console.WriteLine("Сегодня будний день. Вторник");
//         else  if(weekday == 3)
//         Console.WriteLine("Сегодня будний день. Среда");
//         else  if(weekday == 4)
//         Console.WriteLine("Сегодня будний день. Четверг");
//         else  if(weekday == 5)
//         Console.WriteLine("Сегодня будний день. Пятница");
//         else  if(weekday == 6)
//         Console.WriteLine("Сегодня выходной день. Суббота");
//         else  if(weekday == 7)
//         Console.WriteLine("Сегодня выходной день. Воскресение");
//         }
//    else
//    {
//     Console.WriteLine("Дней в неделе всего 7");
//    }




// Задача 10

// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа "+stringNumber[1]);


Задача 13 
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine("Третья цифра " + NumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}