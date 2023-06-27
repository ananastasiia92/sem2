//Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа


Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int result = ((num%100)-(num%10)) / 10;
Console.WriteLine($"{num} -> {result}");
