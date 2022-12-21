Console.WriteLine("Введите 2 числа, ");
Console.Write("Первое : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе : ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.WriteLine($"{a} больше {b} меньше");
}
else if (a < b)
{
Console.WriteLine($"{a} меньше {b} больше");
}
else
{
Console.WriteLine($"{a} равно {b}");
}
