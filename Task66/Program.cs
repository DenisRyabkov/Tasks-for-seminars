// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{
    if (num2 > num1) return num2 + SumNaturalNumbers(num1, num2 - 1);
    if (num2 < num1) return num1 + SumNaturalNumbers(num2, num1 - 1);
    return num2;
}
Console.WriteLine($"{SumNaturalNumbers(numberOne, numberTwo)}");