Console.Clear();

// string[] stringArray = {"hello", "2", "world",":-)"};
// string[] stringArray = {"Russia", "Denmark", "Kazan"};
string[] stringArray = {"1234", "1567", "-2", "computer science"};

string[] CreateNewStringArray(string[] array)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= 3) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];
    
    for(int j = 0, m = 0; j < array.Length; j++)
    {
        if(array[j].Length <= 3)
        {
            newArray[m] = array[j];
            m++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array)
{
    Console.Write("Массив строк: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("].");
    Console.WriteLine();
}

PrintStringArray(stringArray);
string[] newStringArray = CreateNewStringArray(stringArray);
PrintStringArray(newStringArray);

Console.ReadLine();