/*Задача41
Console.Write("Количество чисел М : ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write("Введите число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(numbers)} ");
*/


