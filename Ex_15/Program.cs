/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Является ли день выходным?");
Console.WriteLine("1 - пн, 2 - вт, 3 - ср, 4 - чт, 5 - пт, 6 - сб, 7 - вс");
Console.Write("Введите число от 1 до 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if(weekDay < 1 || weekDay > 7)
{
    Console.WriteLine("Введено некорректное значение");
}
if(weekDay == 6 || weekDay == 7)
{
    Console.WriteLine("Да, это выходной день");
}
if(weekDay > 0 && weekDay < 6)
{
    Console.WriteLine("Нет, это не выходной");
}