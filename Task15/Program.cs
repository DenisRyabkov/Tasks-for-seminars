// Программа принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsWorkDay(number)) Console.WriteLine("Это рабочий день");
else if (IsHoliday(number)) Console.WriteLine("Это выходной день");
else Console.WriteLine("Вы ввели не корректное число");

bool IsWorkDay (int num) 
{
    if (num>=1 && num<6)
    return true;
    return false;
}  

bool IsHoliday (int num) 
{
    if (num>5 && num<8)
    return true;
    return false;
}  

//if(number >= 1 && number <= 7)
//{
  //  if(number == 6 || number == 7) Console.WriteLine("Сегодня выходной");
  //  else Console.WriteLine("Сегодня рабочий день");
//}
//else Console.WriteLine("Вы ввели не корректное число");

