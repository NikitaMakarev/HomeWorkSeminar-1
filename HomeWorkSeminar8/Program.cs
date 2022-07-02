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
