
/*Задача47
int [,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    int [,] newMatrix = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
           newMatrix[i, j] = new Random().Next(min, max +1);
           Console.Write(newMatrix[i, j] + " ");      
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Enter the number of m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of n: ");
int n = Convert.ToInt32(Console.ReadLine());
CreateRandomTwoDemArray(m, n, -99, 100);
*/

/*Задача52
int[,] PrintTwoDimentsionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 100);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void FindArrayColumnMean(int[,] matrix)
{
    Console.Write("The mean of elements in each column is ");
    double mean = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        mean = Math.Round(sum / matrix.GetLength(0), 1);
        Console.Write(mean + " | ");
    }
}
Console.WriteLine("Enter the array's number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the array's number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayresult = new int[m,n];
PrintTwoDimentsionalArray(arrayresult);
FindArrayColumnMean(arrayresult);
*/

/*Задача50
int[,] PrintTwoDimentsionalArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void FindElementInArray(int[,] matrix, int a, int b)
{
    int element = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                element = matrix[i, j];
               
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Элемент с индексом ({a}, {b}) является {element}.");
}
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки элемента: ");
int rowind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца элемента: ");
int colind = Convert.ToInt32(Console.ReadLine());

int[,] arrayresult = new int[m, n];
PrintTwoDimentsionalArray(arrayresult);
if (rowind < arrayresult.GetLength(0) && colind < arrayresult.GetLength(1))
{
    FindElementInArray(arrayresult, rowind, colind);
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Элемент с индексом ({rowind}, {colind}) отсутствует в массиве. ");
}
*/