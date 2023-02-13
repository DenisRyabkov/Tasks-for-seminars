// программа принимает на вход три числа
// и выдает максимальное из этих чисел


Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;

if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}
Console.WriteLine("Максимальное число " + max);