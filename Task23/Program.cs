// Task23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1)
{
    Console.WriteLine("Вы ввели отрицательное или равное нулю число! Введите число заново: ");
    a = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= a; i++)
    Console.WriteLine($"{Math.Pow(i,3)} ");


