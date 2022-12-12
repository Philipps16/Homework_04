Console.Clear();

Console.WriteLine("Введите число: ");
string? a = Console.ReadLine();
int l = a.Length - 1;
double sum = 0;

for (int i = 0; i <= l; i++)
{
    sum = sum + int.Parse(a[i].ToString());
}

Console.WriteLine($"Сумма цифр в числе равна: {sum}");