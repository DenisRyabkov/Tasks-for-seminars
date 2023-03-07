// Напишите программу, которая найдет точки пересечения двух прямых
// заданных уравнениями
// y=k1*x+b1
// y=k2*x+b2
// значения b1,b2,k1,k2 задаются польхователем
// b1=2, k1=5, b2=4, k2=9 -> (-0,5; -0,5)

const int COEEF = 0;
const int CONST = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if(ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEEF]}*x+{lineData1[CONST]} и y={lineData2[COEEF]}*x+{lineData2[CONST]}");
    Console.WriteLine($" имеет координаты({coord[X_COORD]}, {coord[Y_COORD]})");
}
double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData (int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEEF] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONST] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONST] - lineData2[CONST]) / (lineData2[COEEF] - lineData1[COEEF]);
    coord[Y_COORD] = (lineData1[CONST] * coord[X_COORD] + lineData1[CONST]);
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[COEEF] == lineData2[COEEF])
    {
        if(lineData1[CONST] == lineData2[CONST])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        } 
    }
    return true;
}
