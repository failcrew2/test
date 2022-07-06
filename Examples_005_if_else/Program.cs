Console.Write("Введите имя пользавателя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine ("Ура это же маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}