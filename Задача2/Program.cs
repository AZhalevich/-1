// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

 Console.Write("ВВедите первое число : ");
int numberA = int.Parse(Console.ReadLine()!);
 Console.Write("ВВедите второе число : ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA > numberB)
{
    Console.WriteLine($"MAX={numberA} MIN={numberB}");
}
else{
     Console.WriteLine($"MAX={numberB} MIN={numberA}");
}