/*Задача56
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}

int[,] GetRandomArray(int array)
{
    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = new Random().Next(array);
        }
    }
    return resultArray;
}

void FindMinSumRow(int[,] array)
{
    int min = int.MaxValue; //Представляет наибольшее возможное значение типа Int32. Это поле является константой. MaxValue = 2147483647.
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        Console.WriteLine($"row {i + 1}: {sum}");
        if (sum < min)
        {
            min = sum;
            result = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой чисел равна {result + 1}.");
}
int[,] matrix2 = GetRandomArray(10);
PrintMatrix(matrix2);
FindMinSumRow(matrix2);
*/

/*Задча54
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" ");
}

int[,] RandomArray(int array)
{
    Console.WriteLine("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] resultarray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultarray[i, j] = new Random().Next(array);
        }
    }
    return resultarray;
}

int[,] SortDescendingArray(int[,] sorted)
{
    for (int i = 0; i < sorted.GetLength(0); i++)
    {
        int size = 0;
        while (size < sorted.GetLength(1) - 1)
        {
            for (int j = 0; j < sorted.GetLength(1) - 1; j++)
            {
                if (sorted[i, j] > sorted[i, j + 1])
                {
                    int temp = sorted[i, j];
                    sorted[i, j] = sorted[i, j + 1];
                    sorted[i, j + 1] = temp;
                }
            }
            size++;
        }
    }
    return sorted;
}

int[,] matrix1 = RandomArray(10);
PrintMatrix(matrix1);
SortDescendingArray(matrix1);
PrintMatrix(matrix1);
*/


/*Задача62
int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);

        }

    }

    return newMatrix;
}

void PrintArray (int [,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i, j] + " ");

        }

        Console.WriteLine ();
    }    

}

int[,] FillSpiralBorders()
{
    int side = 4;
    int SideElement = 1;
    int[,] result = new int[side, side];
    int num = 1;
    for (int c = 0; c < side - SideElement  * 2; c++)
    {
        for (int j = c; j < side - SideElement  - c; j++, num++)
            result[c,j] = num;

        for (int i = c; i < side - SideElement  - c; i++, num++)
            result[i,side - SideElement  - c] = num;
        for (int j = side - SideElement  - c; j >= c; j--, num++)
            result[side - SideElement  - c,j] = num;
        for (int i = side - SideElement  * 2 - c; i > c; i--, num++)
            result[i,c] = num;
    }
    return result;
}

int[,] myArray =FillSpiralBorders();
PrintArray(myArray);
*/