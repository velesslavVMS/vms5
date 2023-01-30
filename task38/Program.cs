double[] array = {78.73, 3.57, 7.96, 0.6, 22.47, 2.12, 78.75, 25.0};

double max = array[0];
for (int i = 1; i < array.Length; i++)
{
if(array[i] > max)
max=array[i];

}
Console.WriteLine($"максимальное число равно: {max}");
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
if(array[i] < min)
min=array[i];
}

Console.WriteLine($"минимальное число равно: {min}");
Console.WriteLine($"разница между max & min равна: {max-min}");


