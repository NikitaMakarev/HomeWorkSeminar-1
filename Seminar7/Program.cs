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
    {
        for(int j = 0; j < b; j++)
        {
           newMatrix[i, j] = i + j;
           Console.Write(newMatrix[i, j] + " ");      
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateArrayIJ(4, 5);
*/
/*
int [,] CreateArrayEvenIndexQuad(int a, int b)
{
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
           if (i ==j)   
        }
        Console.WriteLine();
    }
    return newMatrix;
}
int [,] myArray = CreateArrayEvenIndexQuad(4,5)

int[,] array = CreateArrayIJ(4, 5, 2, 15);
*/