// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число = ");
int N = int.Parse(Console.ReadLine());
int Two = 2;

Console.WriteLine("Хоба");
while(Two < N)
{
    Console.WriteLine(Two);
    Two = Two + 2;
}

