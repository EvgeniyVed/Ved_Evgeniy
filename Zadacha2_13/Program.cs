// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int numbers = Convert.ToInt32(Console.ReadLine());
int itog = 0;
int i = 10;
if (numbers>100)
{
    do
    {
        itog = numbers % i;
        i = i * 10;
    } while (numbers>(i*10));
    Console.WriteLine(itog/(i/100));
} else
Console.WriteLine("Третьей цифры нет");
