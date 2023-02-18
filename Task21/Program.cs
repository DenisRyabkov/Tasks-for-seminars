// Программа принимает на вход координаты двух точек
// и и находит расстояние между ними в 3Д пространстве
// а(3,6,8); b(2,1,-7) - 15,84
// a(7,-5,0); b(1,-1,9) - 11,53

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distans = Distans(ax, ay, az, bx, by, bz);

double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine(distansRound);

double Distans(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

