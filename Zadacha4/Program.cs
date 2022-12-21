Console.WriteLine("Введите 3 числа ");
Console.Write("Первое : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье : ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > max)
{
max = a;
}

if (b > max)
{
max = b;
}

if (c > max)
{
max = c;
}

Console.WriteLine("max = " + max);