
// test 
Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
Console.WriteLine(FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
Console.WriteLine(FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
Console.WriteLine(FindEvenIndex(new int[] { 8, 8 }));
Console.WriteLine(FindEvenIndex(new int[] { 8, 0 }));
Console.WriteLine(FindEvenIndex(new int[] { 0, 8 }));
Console.WriteLine(FindEvenIndex(new int[] { 7, 3, -3 }));
Console.WriteLine(FindEvenIndex(new int[] { 8 }));
Console.WriteLine(FindEvenIndex(new int[] { 0, 0, 0, 0, 0 }));



// decision
int FindEvenIndex(int[] arr)
{
    int summOne = 0, SummTwo = 0;
    int arraySize = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            summOne += arr[j];
        }
        for (int j = i + 1; j < arraySize; j++)
        {
            SummTwo += arr[j];
        }
        if (summOne == SummTwo)
        {
            return i;
        }
        summOne = SummTwo = 0;
    }
    return -1;
}