/*
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

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
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

int [] myArray = CreateRandomArray(number, 100, 1000);
Console.WriteLine("Input the number:  ");
int number = Convert.ToInt32(Console.ReadLine());

int quantity = QuantityPositive(array);
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

