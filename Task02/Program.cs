// программа на вход принимает два числа и
// выдает какое число больше, а какое меньше

Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B) 
{
 Console.WriteLine(A + " больше " + B);   
}
else{
    Console.WriteLine(B + " больше " + A);  
}