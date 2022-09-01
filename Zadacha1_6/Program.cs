// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Hello, World!");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0 )
{
    Console.WriteLine("Число {0} является четным",number1);
} else
{
    Console.WriteLine("Число {0} не является четным",number1);
}