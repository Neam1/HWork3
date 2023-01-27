// Task19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10000;
int a2 = (a / 1000) % 10;
int a4 = (a % 100) / 10;
int a5 = a % 10;
if (a1 == a5 && a2 == a4)
    Console.WriteLine("Это число является палиндромом!");
else
    Console.WriteLine("Это число не является палиндромом!");