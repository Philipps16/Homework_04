Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int x = 1; x <= b; x++)
{
    res = res * a;
    
}
Console.WriteLine($"Число {a} в степени {b} равно {res}");