// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
//int A = Convert.ToInt32(Console.ReadLine());
if (!int.TryParse(Console.ReadLine(), out int A))
{
  Console.WriteLine("А не является числом");
  return;
}
Console.Write("Введите число B: ");
//int B = Convert.ToInt32(Console.ReadLine());
if (!int.TryParse(Console.ReadLine(), out int B))
{
  Console.WriteLine("B не является числом");
  return;
}

Console.WriteLine(Math.Pow(A, B));