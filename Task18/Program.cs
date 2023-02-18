// программа по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

string quarter = Quarter(number);

string result = $"Возможные координаты четверти: {quarter}";
Console.WriteLine(result);              

string Quarter (int num)
{
   if(num == 1) return "x > 0, y > 0";
   if(num == 2) return "x < 0, y > 0";
   if(num == 3) return "x < 0, y < 0";
   if(num == 4) return "x > 0, y < 0";
   return "нет такой четверти";
}
