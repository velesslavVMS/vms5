void Input(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); 
}
void Output(int[] array)
{
int count = 0; 
for (int i = 0; i < array.Length; i++) 
{   
  int k = array[i] % 2;
  if (k==0)
  count = count+1;
}
Console.WriteLine($"Число четных чисел равно: {count}");
}
 
Console.Write("Введите кол-во элементов массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
Input(array); 
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
Output(array);
