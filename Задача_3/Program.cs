/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

int a;
Console.Write("Введите число: ");
bool flag =int.TryParse(Console.ReadLine()!,out a);

if (flag)
{
    if(a%2==0)
    Console.Write("Да");
else
    Console.Write("Нет");
}