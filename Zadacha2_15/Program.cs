// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int week = Convert.ToInt32(Console.ReadLine());
if (week >0 && week <8)
{
    if (week >0 && week <6)
    {
    Console.WriteLine("Рабочий день");
    } else
    Console.WriteLine("Выходной день");
} else
Console.WriteLine("Нет такого дня недели");



