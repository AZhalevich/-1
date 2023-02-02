// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("ВВедите число : ");
int N = int.Parse(Console.ReadLine()!);
int A  =2;

if(N > 1)
{
    while(A <= N)
    {Console.Write($"{A} ");
    A = A+2;}
}