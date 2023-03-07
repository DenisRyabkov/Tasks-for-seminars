// программа принимает на вход три числа
// и проверяет может ли существовать треугольник со сторонами такой длины
// (каждая сторона меньше суммы двух других)

Console.WriteLine ("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());

bool IsTriangleExist(int A, int B, int C)
{
return A+B>C && A+C>B && B+C>A;
}

bool result = IsTriangleExist(A,B,C);
Console.WriteLine(result? "Треугольник существует": "Треугольник НЕ существует");