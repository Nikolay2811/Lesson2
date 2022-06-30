// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Ведите порядковый номер дня недели => ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);
if (a > 0 && a < 8)
{
    if (a> 0 && a < 6)
    Console.WriteLine("Это будний день ");
    else
     Console.WriteLine("Это выходной день ");
        
    
} 
else
 Console.WriteLine("Нет такого дня недели ");

