// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число=> ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
if (a < 100)
{
    Console.WriteLine("третьёй цифры нет ");
} 
else
{
    while (a > 999)
    {
       a =  a / 10;
    }

Console.WriteLine("Третье число " + a%10);
}