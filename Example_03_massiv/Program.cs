Console.Clear();

Console.WriteLine("Введите размер массива");

int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Ошибка, число должно быть больше 0. Попробуйте еще.");
    n = Convert.ToInt32(Console.ReadLine());
}
int [] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");