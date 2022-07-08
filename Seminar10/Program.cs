
/*Задача1
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for( int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
       if(array [i].Length >= 5)
        count++;

    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/


string [] ArrayCombination(string[] array1, string[] array2)
{
    int size;
    int minsize;
    if(array1.Length > array2.Length)
    {
       size = array1.Length;
       minsize = array2.Length;

       string [] newArray = new string [size];
       for ( int i = 0; i < minsize; i++)
        newArray[i] = array1[i] + array2[i];

       for (int i = minsize; i < size; i++)
         newArray[i] = array2[i];
        
    }
    else
    {
       size = array2.Length;
       minsize = array2.Length;

        string [] newArray = new string [size];

       for ( int i = 0; i < minsize; i++)
         newArray[i] = array1[i] + array2[i];

       for (int i = minsize; i < size; i++)
         newArray[i] = array1[i];
    }

 return newArray;
      
}