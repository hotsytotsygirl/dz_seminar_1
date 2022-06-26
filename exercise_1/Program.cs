//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число a:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numB = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(numA > numB) max = numA; min = numB;
if(numA < numB) max = numB; min = numA;

Console.Write("Максимальное число ");
Console.WriteLine(max);
Console.Write("Минимальное число ");
Console.WriteLine(min);