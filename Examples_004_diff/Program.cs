// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

    void CheckingNumber(string number)
    {
        if (number[0]==number[4] || number[1]==number[3])
        {
            Console.WriteLine($"Ваше число: {number} - палиндром.");
        }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
        if (number!.Length == 5)
    {
        CheckingNumber(number);
    }
         else Console.WriteLine($"Введи правильное число");
         
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);

*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int a1 = Cord("x", "A");
int b1 = Cord("y", "A");
int c1 = Cord("z", "A");
int a2 = Cord("x", "B");
int b2 = Cord("y", "B");
int c2 = Cord("z", "B");

int Cord(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a1, double a2, 
                double b1, double b2, 
                double c1, double c2){
  return Math.Sqrt(Math.Pow((a2-a1), 2) + 
                   Math.Pow((b2-b1), 2) + 
                   Math.Pow((c2-c1), 2));
}

double segmentLength =  Math.Round (Decision(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");