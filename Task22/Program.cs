// Программа принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 1 1
// 2 4
// 3 9
// 4 16
// 5 25

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) Console.WriteLine("Введено не корректное число");
else
{
int index = 1;
while (index <= number)
{
    Console.WriteLine($"{index, 5} {index*index, 5}");
    index++;
}
}