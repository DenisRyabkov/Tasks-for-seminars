// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//NaturalNumbers(number1, number2);

int NaturalNumbers(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if ((num1 != 0) && (num2 == 0)) return NaturalNumbers(num1 - 1, 1);
    else return NaturalNumbers(num1 - 1, NaturalNumbers(num1, num2 - 1));
}
Console.WriteLine($"{NaturalNumbers(number1, number2)}");