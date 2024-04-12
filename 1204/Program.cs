Console.Write("x= ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("t= ");
double t = Convert.ToDouble(Console.ReadLine());
double koren = 1 + Math.Pow(Math.Sin(x), 2) + x * t * Math.Pow(Math.Cos(x * t), 2); // переменная для проверки подкоренного выражения
double zn = Math.Pow(t, 3) * x + Math.Sqrt(koren);// переменная для проверки равенства нулю знаменателя
double f;
if (koren < 0 || zn == 0)
    Console.WriteLine("Введите другие значения х и t");
else
{
    f = (1 / (1 + x * x) - 2 * x * t) / zn;
    Console.WriteLine("f= " + f);
}
Console.ReadKey(true);
