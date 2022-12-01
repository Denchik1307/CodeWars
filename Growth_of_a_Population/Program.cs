
// test
Console.WriteLine(NbYear(1500, 5, 100, 5000));
Console.WriteLine(NbYear(1500000, 2.5, 10000, 2000000));
Console.WriteLine(NbYear(1500000, 0.25, 1000, 2000000));
Console.WriteLine(NbYear(1500000, 0.25, -1000, 2000000));
Console.WriteLine(NbYear(1500000, 0.25, 1, 2000000));
Console.WriteLine(NbYear(1500000, 0.0, 10000, 2000000));
Console.WriteLine(NbYear(1000, 2.0, 50, 1214));


// decision
int NbYear(int p0, double percent, int aug, int p)
{
    int count = 0;
    for (int i = 1; p0 < p; i++)
    {
        p0 = (p0 + ((int)(p0 * (percent / 100))) + aug);
        count = i;
    }

    return count;
}