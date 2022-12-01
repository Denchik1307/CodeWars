

// test
Console.WriteLine(Order("is2 Thi1s T4est 3a"));
Console.WriteLine(Order("4of Fo1r pe6ople g3ood th5e the2"));
Console.WriteLine(Order(""));
Console.WriteLine(Order("d4o dru7nken sh2all w5ith s8ailor wha1t 3we a6"));
Console.WriteLine(Order("3 6 4 2 8 7 5 1 9"));


// decision
string Order(string words)
{
    string[] list = words.Split(" ");
    string[] replaseAray = new string[list.Length];
    foreach (string i in list)
    {
        int pos = 0;
        foreach (char j in i)
        {
            if (int.TryParse(j.ToString(), out pos)) break;
        }
        if (pos > 0) replaseAray[pos - 1] = i;
    }

    return String.Join(" ", replaseAray);
}