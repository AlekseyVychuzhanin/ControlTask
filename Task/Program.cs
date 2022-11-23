Console.Clear();

// string[] stringArray = {"hello", "2", "world",":-)"};
// string[] stringArray = {"Russia", "Denmark", "Kazan"};
// string[] stringArray = {"1234", "1567", "-2", "computer science"};

string[] CreateUserStringArray()
{
    Console.Write("Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());
    while(sizeArray < 0)
    {
        Console.WriteLine("\nРазмер массива - это целое положительное число.");
        Console.Write("\nВведите новое значение: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }

    string[] array = new string[sizeArray];

    if(sizeArray == 0) 
        Console.WriteLine("\nРазмер массива = 0, массив пустой!");
    else 
    {
        for(int i = 0; i < sizeArray; i++)
        {
            Console.Write("\nВведите элемент массива: ");
            string? value = Console.ReadLine();
            while(value == String.Empty)
            {
                Console.Write("\nВы не ввели значение. Введите элемент массива: ");
                value = Console.ReadLine();
            }
            if(value != null && value != String.Empty) array[i] = value;
        }
    }
    return array;

}


string[] CreateStringArray(string[] array)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length;i++)
        if(array[i].Length <= 3) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array)
{
    Console.Write("\nСозданный массив: [");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.Write("].");
    Console.WriteLine();
}

string[] stringArray = CreateUserStringArray();
PrintStringArray(stringArray);
if(stringArray.Length > 0)
{
    string[] newStringArray = CreateStringArray(stringArray);
    PrintStringArray(newStringArray);
}

Console.ReadLine();