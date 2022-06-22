// шаблон 
/*Задача1
int[] CreateRandomArray(int size, int min, int max)
{
    int [] newArray = new int [size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] =  new Random().Next(min, max + 1);
       Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindPositiveSum(int[] array) // сложение
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if (array[i] > 0) sum += array[i];  
    }
    return sum;
}

int FindNegativeSum(int[] array) // вычитание
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if (array[i] < 0) sum += array[i];  
    }
    return sum;
}

int [] myArray = CreateRandomArray(12, -9, 9); // дома более подробно вводить

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));
*/

/*Задача2
int[] ReverseElementsArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      array[i] *= -1;
    }
    return array;
}
*/

/*Задача3
bool FindNumberInArray(int[] array, int aa)
{
  bool bb = false;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i] == aa) return true;
  }
  return false;
} 
*/

/*Задача4
int FindCountElemensInRenge(int[] array, int min, int max)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if (array[i] > min && array[i] < max) count++;
     }
      return count;
}
string OutputArrayConsole(int [] array)
{
  string ss = "";
  for(int i = 0; i < array.Length; i++)
  {
    ss + = array[i] + ",";
  }
  return ss;
}
*/
/*
//Задача2
Console.WriteLine("reverse array " + OutputArrayConsole(ReverseElementsArray(myArray)));
//Задача3
int find = 16;
Console.WriteLine("В массиве число " + find + ((FindNumberInArray(myArray,find)) ? "присутсвует" : "не присутсвует"));
//Задача4
int minnum = 10;
int maxnum = 99;
Console.WriteLine("Количество цифр в отрезке " + minnum + "до" + "=" + FindCountElemensInRenge(myArray, minnum, maxnum));    
*/