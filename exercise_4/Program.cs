//Задача 8: Написать программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int jump = 2;

while (jump <= num)
{
    Console.WriteLine (jump);
    jump +=2;
}

//просто прибавляет +2, пока не достигнет значения num