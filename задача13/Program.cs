//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 99){
    Console.WriteLine("Это не трехзначное число");
    return;
}
while(a > 999){
    a /= 10;
}
int result = a%10;
Console.WriteLine($"->{result}");
