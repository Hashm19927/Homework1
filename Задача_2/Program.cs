/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int a,b,c;
int max;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!,out a);
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!,out b);
Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!,out c);
if (a>b)
{
    max=a;
    Console.Write($"max={a}");
}
else if (b>c)
{
    max=b;
    Console.Write($"max={b}");
}
else if (c>a)
{
    max=c;
    Console.Write($"max={c}");
}