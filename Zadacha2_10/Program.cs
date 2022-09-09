// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers>99 && numbers<1000)
{
    Console.WriteLine(numbers % 100 / 10);
} else
Console.WriteLine("Не трехзначное число");
