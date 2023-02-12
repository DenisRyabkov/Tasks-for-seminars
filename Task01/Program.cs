// напишите программу, которая:
// 1. принимает на вход два числа,
// 2. проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A == B * B)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}