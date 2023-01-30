void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(0, 100); 
}

void Output(int[] array)
{
int sum=0, k=0;
while (k<array.Length)
{
sum=sum+array[k];
k=k+2;
}
Console.WriteLine("Индекс 1-й нечетной позиции равен 0.");
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {sum}");
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Output(array);

