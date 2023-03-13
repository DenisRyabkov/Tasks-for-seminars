// программа принимает на вход два числа А и В,
// и возводит число А в степень В с помощью рекурсии
// А = 3; B = 5 -> 243

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if(degree < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine($"{number}, {degree} -> {PowerNumber(number, degree)}");

int PowerNumber(int num, int deg)
{
    //if (deg == 0) return 1;
    //else return num * PowerNumber(num, deg-1);

    if (deg == 0) return 1;
    else if (deg % 2 == 0) return PowerNumber(num * num, deg / 2);
    else return PowerNumber(num, deg -1) * num;
}
