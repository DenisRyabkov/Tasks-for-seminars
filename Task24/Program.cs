﻿// Программа которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А
// 7 -> 28

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");

int SumNumbers(int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
     checked
     { 
         sum = sum + i;
     }
    }
    return sum;
}
