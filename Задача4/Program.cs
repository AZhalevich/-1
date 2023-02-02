// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

 Console.Write("ВВедите первое число : ");
int A = int.Parse(Console.ReadLine()!);
 Console.Write("ВВедите второе число : ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("ВВедите третье число : ");
int C = int.Parse(Console.ReadLine()!);
int MAX = 0;
if (A > B && A > C)
{
    MAX = A;
    }
else if (B > A && B > C)
{
    MAX = B;
}
else if (C > A && C > B)
{
    MAX = C;
}
Console.WriteLine($"MAX={MAX}");