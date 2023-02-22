// Программа принимает на вход число
// и выдает количество цифр в числе
// 89126 -> 5

int number = Prompt("Введите число: ");
int scoreDigit = ScoreDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {scoreDigit}");

int Prompt(string mess)
{
  Console.WriteLine(mess);  
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int ScoreDigit(int num)
{
    scoreDigit = 0;
    while (num > 0)
    {
        num = num/10;
        scoreDigit = scoreDigit +1;
    }
    return scoreDigit;
}