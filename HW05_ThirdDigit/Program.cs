//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digit = (int) Math.Floor(Math.Log10(a)) - 2;
    int digit2 = (int) Math.Pow(10, digit);
Console.WriteLine((a/digit2%10)%10);
}