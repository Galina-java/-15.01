int[] CreateArray(int size_1234)
{
    int[] createdArray = new int[size_1234];
    Random rnd = new Random();
    for (int i = 0; i < size_1234; i++)
    {
        createdArray[i] = rnd.Next(100, 1000);
        //Console.Write(createdArray[i] + " ");
    }
    return createdArray;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write($"{arrayToShow[i]} ");
    }
}

int NumberOfElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

int size = 10;
int[] arrayTask1 = CreateArray(size);
ShowArray(arrayTask1);
Console.WriteLine ();
Console.WriteLine( "Количество чётных чисел в массиве "+ NumberOfElem(arrayTask1));