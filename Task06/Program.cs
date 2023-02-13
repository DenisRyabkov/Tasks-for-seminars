// Программа на вход принимает число 
// и выдает является ли число четным

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 2 == 0)
{
    Console.WriteLine(A + " четное");
}
else
{
    Console.WriteLine(A + " НЕ четное");
}