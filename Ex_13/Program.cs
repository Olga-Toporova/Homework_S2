/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int moduleNum = Math.Abs(number);
string stringNum = Convert.ToString(moduleNum);
if (stringNum.Length < 3)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine(stringNum[2]);
}