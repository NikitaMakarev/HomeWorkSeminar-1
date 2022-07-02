/*Задача1
int [,] CrateTwoDimArray(int m, int n, int max, int min)
{
    int[,] array = new int[m, n];

    for(int i = 0; i < m; i++)
         for(int j = 0; j < n; j++)
         array [i, j] = new Random().Next(min, max+1);
    
    return array;
}

void ShowArray(int [,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
         for(int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");

         Console.WriteLine();
     }
}

int [,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

int [,] myArray = CrateTwoDimArray(4, 5, 1, 9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0, myArray.GetLength(0) -1);
Console.WriteLine();
ShowArray(myArray);
*/
/*Задача3
int [,] ChangeRowsColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for( int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}

int m, n, min, max;
do
{
    Console.WriteLine("Введите данные.Число строк должно быть равно числу столбцов: ");
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    min = Convert.ToInt32(Console.ReadLine());
    max = Convert.ToInt32(Console.ReadLine());
}

while(m != n);
int [,] myArray = CrateTwoDimArray(m, n, min, max);
ShowArray(myArray);
Console.WriteLine();
myArray = ChangeRowsColumns(myArray);
ShowArray(myArray);
*/

/*Задача3
int[,] DeleteRowColumn(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow, minColumn];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            if(array [i, j] < min) 
            {
              min = array[i, j];
              minRow = i;
              minColumn = j;
            }  
        }
    }

   for(int i = 0; i < array.GetLength(0); i++)
      array[i, minColumn] = 0;
   for( int j = 0; j < array.GetLength(1); j++)
     array[minRow, j] = 0;
   return array;
}

int [,] myArray = CrateTwoDimArray(4, 6, 1, 9);
ShowArray(myArray);
Console.WriteLine();
myArray = DeleteRowColumn(myArray);
ShowArray(myArray);
*/