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


int WordStartingVowel(string [] array)
{
    int count = 0;
    char [] vowel = {'a', 'e', 'i', 'o', 'u', 'y'};

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowel.Length; j++)
            if (Char.ToLower(array[i][0]) == vowel[j]) 
            count++;
    } 
    return count;
}

Console.Write("Input word count: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine(" " + WordStartingVowel(names));
*/

/*Задача2
string [] IntegratedArrayPairwise(string [] array)
{
    int addition = 0;
    if (array.Length % 2 != 0) addition = 1;    
    string [] newArray = new string [array.Length / 2 + addition];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i * 2 + 1 < array.Length) newArray[i] = array[i * 2] + array[i * 2 + 1];
        else newArray[i] = array [i * 2];
    }
    return newArray;
}

void PrintStringArray(string [] array)
{
    foreach (string word in array) 
        Console.Write(word + ", ");
}

string [] array = {"qwe", "wer", "ert", "viv","Miv","bood"};
PrintStringArray(array);
Console.WriteLine();
string [] newArray = IntegratedArrayPairwise(array);
PrintStringArray(newArray);

//Оператор foreach: перечисляет элементы коллекции и выполняет тело для каждого элемента коллекции.
*/
