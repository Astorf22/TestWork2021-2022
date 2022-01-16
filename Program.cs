Console.Clear();

int[] FillArray(int A, int min, int max)  
{
    int[] array = new int[A];
    for (int a = 0; a < array.Length; a++)
    {
        array[a] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)  
{
    for (int b = 0; b < arr.Length; b++)
    {
        Console.Write(arr[b] + " ");
    }
    System.Console.WriteLine();

}

int EvenNumbers(int[] arr) 
{
    int count = 0;
    for (int c = 0; c < arr.Length; c++)
    {
        if (arr[c] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] NewArray(int[] arr)   
{
    int[] newArray = new int[EvenNumbers(arr)];
    int d = 0;
    for (int e = 0; e < arr.Length; e++)
    {
        if (arr[e] % 2 == 0)
        {
            newArray[d] = arr[e];
            d++;
        }
    }
    return newArray;
}

int[] Array = FillArray(10, -1000, 1000);

PrintArray(Array);

Console.WriteLine("                       ->");

int[] new2Array = NewArray(Array);

PrintArray(new2Array);