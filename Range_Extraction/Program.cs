

// test
Console.WriteLine(Extract(new[] { 1, 2 }));
Console.WriteLine(Extract(new[] { 1, 2, 3 }));
Console.WriteLine(Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));
Console.WriteLine(Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }));



// decision
string Extract(int[] args)
{
    string output = string.Empty;
    int temp;
    int ie = 0;
    while (ie < args.Length)
    {
        if (args.Contains(args[ie] + 1) && args.Contains(args[ie] + 2))
        {
            output = output + $"{args[ie]}-";
            ie++;
            temp = args[ie];
            while (args.Contains(temp + 1))
            {
                temp++;
                ie++;
            }
            output += $"{temp},";
            ie++;
        }
        else
        {
            output = output + $"{args[ie]},";
            ie++;
        }
    }
    output = output.TrimEnd(',');
    return output;
}