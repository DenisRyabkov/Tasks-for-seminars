// Программа принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) Console.WriteLine("Введено не корректное число");
else
{
int index = 1;
while (index <= number)
{
    Console.WriteLine($"{index, 5} {Math.Pow(index, 3), 5}");
    index++;
}
}
