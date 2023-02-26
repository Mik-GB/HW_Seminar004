// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// //int A = Convert.ToInt32(Console.ReadLine());
// if (!int.TryParse(Console.ReadLine(), out int A))
// {
//   Console.WriteLine("А не является числом");
//   return;
// }
// Console.Write("Введите число B: ");
// //int B = Convert.ToInt32(Console.ReadLine());
// if (!int.TryParse(Console.ReadLine(), out int B))
// {
//   Console.WriteLine("B не является числом");
//   return;
// }

// Console.WriteLine(Math.Pow(A, B));

Console.WriteLine("Введите число A");
if (!int.TryParse(Console.ReadLine(), out int A))
{
  Console.WriteLine("А не является числом");
  return;
}
Console.WriteLine("Введите число B");
if (!int.TryParse(Console.ReadLine(), out int B))
{
  Console.WriteLine("B не является числом");
  return;
}
if (B < 0)
{
  Console.WriteLine("Неверное значение числа В");
  return;
}
int Natur(int A, int B)
{
  int result = 1;
  if (B > 0)
    for (int i = 1; i <= B; i++)
    {
      result = result * A;
    }
  return result;
}
// Console.WriteLine(Natur(3, 5)); 
Console.WriteLine($"число {A} в натуральной степени {B} = {Natur(A, B)}");