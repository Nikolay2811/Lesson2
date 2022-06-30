// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Вdедите трехзpачное число ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
if (numberInt > 99 && numberInt <1000) 
{
    Console.WriteLine((numberInt/10)%10);
} 
else
{
    Console.WriteLine("Сказано же трехзначное, что не понятно? Еще раз, введите ТРЕХЗНАЧНОЕ ЧИСЛО ");
}
