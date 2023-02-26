// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
if (!int.TryParse(Console.ReadLine(), out int number))
{
  Console.WriteLine("Не является числом");
  return;
}
// if (number < 0) number *= -1;
int SummNumber(int number)
{
  int SummNumber = 0;
  while (number > 0)
  {
    SummNumber = SummNumber + number % 10;
    number = number / 10;
  }
  return SummNumber;
}
Console.WriteLine($"Сумма цифр числа: {SummNumber(number)}");