
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

/*Задача2
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

string [] ArrayCombination(string[] array1, string[] array2)
{
    int minsize;

 if(array1.Length > array2.Length)
    {
       minsize = array2.Length;
       for(int i =0; i < minsize; i++)
         array1 [i] += array2[i];
       return array1;
    }
    else
    {
       minsize = array2.Length;
       for(int i =0; i < minsize; i++)
         array2 [i] += array1[i];
       return array2;
       
    }

}

Console.Write("Input number of names: ");
int size1 = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size1);

Console.Write("Input number of names: ");
size2 = Convert.ToInt32(Console.ReadLine());

string[] names2 = CreateStringArray(size2);

//Console.WriteLine("Number of long words is " + NumberOfLongWords(names));

ShowArray(ArrayCombination(names, names2));
*/

/*Задача3
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

int CountYW(string [] array, char a, char b)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++)
   {
     if (array[i][0] == a || array[i][0] == b)
        count++;
   }
   return count;
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Symbol: ");
char a = Convert.ToChar(Console.ReadLine());
Console.Write("Input Second Symbol: ");
char b = Convert.ToChar(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine(" " + CountYW(names, a, b));
Console.WriteLine(names[1].ToLower());
*/