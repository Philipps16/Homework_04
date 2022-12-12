Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 10)
{
    Console.WriteLine("Это не число, попробуйте еще:");
    a = Convert.ToInt32(Console.ReadLine());
}
string b = a.ToString();
char [] array = b.ToCharArray();

int sum = array [0];
for (int i = 0; i < (array.Length - 2); i++)
{
    sum = sum + array[i+1];
}

Console.WriteLine($"Сумма цифр в числе равна: {sum}");