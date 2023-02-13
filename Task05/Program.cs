// Принять на вход одно целое число (N)
// на выходе показать все целые числа 
// в промежутке от -N до N
// Пример: 4 -> -4 -3 -2 -1 0 1 2 3 4 

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int index = -number;
while (index <= number)
{
    Console.Write(index + " ");
    index++;
}
