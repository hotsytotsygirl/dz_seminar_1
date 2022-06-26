//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

Console.WriteLine("Введите число a:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c:");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.Write("Максимальное число ");
Console.WriteLine(max);