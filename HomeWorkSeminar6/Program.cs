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

/*Задача45
int[] arrayCopy(int[] array)
{
    int[] copyofArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        copyofArray[i] = array[i];
    }

    return copyofArray;
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }

    Console.WriteLine();
}
int[] myArray = {17, -3, 1, 8, 0, -12};
Console.WriteLine("Present array: ");
printArray(myArray);

int[] newArray = arrayCopy(myArray);
Console.WriteLine();
Console.WriteLine("Copy of the array: ");
printArray(newArray);
*/