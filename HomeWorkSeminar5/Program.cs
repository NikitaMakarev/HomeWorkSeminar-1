/*Задача34
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next( min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int QuantityPositive (int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) quantity ++;
    }
    return quantity;
}

int [] myArray = CreateRandomArray(4, 100, 1000);

int quantity = QuantityPositive(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
*/


/*Задача36
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next( min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int CheckNumber(int [] array)
{
    int sum = 0;    
    for(int i = 0; i < array.Length; i ++)
    {
       if(i % 2 != 0) sum += array[i];
    }
    
  return sum;
}

int [] myArray = CreateRandomArray(4, 1, 100);

Console.WriteLine("Sum of numbers is  " + CheckNumber(myArray));
*/

/*Задача38
double[] arrayNumbers = new double[5];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 99);
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
*/


