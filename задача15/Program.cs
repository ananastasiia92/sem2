// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int numberOfWeekDay = int.Parse(Console.ReadLine());

if (numberOfWeekDay > 5 && numberOfWeekDay < 8){
    Console.WriteLine("Это выходной");
}
if (numberOfWeekDay >= 1 && numberOfWeekDay < 6){
    Console.WriteLine("Это будний день");
}
if (numberOfWeekDay > 7){
    Console.WriteLine("Это не день недели");
}


