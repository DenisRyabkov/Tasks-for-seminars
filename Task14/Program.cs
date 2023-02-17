// Программа принимет на вход число
// и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Multi(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool Multi (int num) 
{
    return num % 7 == 0 && num % 23 == 0;
}
