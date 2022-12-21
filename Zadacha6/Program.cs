Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int remDiv = a % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
