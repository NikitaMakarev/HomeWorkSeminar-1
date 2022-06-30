/*Задача1
int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int [,] newMatrix = new int[a, b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
           newMatrix[i, j] = new Random().Next(min, max +1);
           Console.Write(newMatrix[i, j] + " ");      
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);
*/

/*Задача2
int [,] CreateArrayIJ(int a, int b)
{
    int [,] newMatrix = new int[a, b];

    for(int i = 0; i < a; i++)
        for(int j = 0; j < b; j++)
           newMatrix[i, j] = i + j;     
    
    return newMatrix;
}
void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(newMatrix[i, j] + " ");      
        }
        Console.WriteLine();
    }
}

int[,] array = CreateRandomTwoDemArray(4, 5);
*/
/*Задача3
int [,] UpdateArrayEvenIndexQuad(int [,] array)
{
    int step = 2;
    for(int i = 0; i < array.GetLength(0); i+= step)
        for(int j = 0; j < array.GetLength(1); j+= step)
            array[i,j] *= array[i,j];

    return array;
}

int [,] myArray = CreateRandomTwoDemArray(4, 5, 2, 15);

Console.WriteLine();

CreateArrayEvenIndexQuad(myArray);
*/

/*Задача4
int [,] SumOfDiagonal(int [,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        sum += array[i,i];

    return sum;
}

int [,] myArray = CreateRandomTwoDemArray(7, 2, 15);

Console.WriteLine(SumOfDiagonal(myArray));
*/
