// Программа принимает на вход число (N), 
// а на выходе показывает все четные от 1 до N

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i = i + 2)
{
    Console.Write(i + ", ");
}

