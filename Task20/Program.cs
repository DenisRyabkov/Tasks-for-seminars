// программа принимает на вход координаты двух точек
// и находит расстояние между ними в 2Д пространстве
// а(3,6); в(2,1) -> 5,09
// а(7,-5); в(1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

double distans = Distans(ax, ay, bx, by);

double distansRound = Math.Round(distans, 2, MidpointRounding.ToZero);
Console.WriteLine(distansRound);

double Distans(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

