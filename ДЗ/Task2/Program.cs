// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int a = new Random( ).Next(100, 1000);
int res = a/100*10 + a%10;
Console.WriteLine(a);
Console.WriteLine(res);

