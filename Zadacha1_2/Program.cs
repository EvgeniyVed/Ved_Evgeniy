// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Hello, World!");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) 
{
    Console.WriteLine("Число {0} больше, чем число {1}", number1, number2);
} else if (number1 < number2)
{
    Console.WriteLine("Число {0} больше, чем число {1}", number2, number1);
} else
{
    Console.WriteLine("Числа {0} и {1} равны", number1, number2 );
}