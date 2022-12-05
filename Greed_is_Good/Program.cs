
// test
Console.WriteLine(Score(new int[] {1, 4, 1, 5, 4}));


// decision
int Score(int[] dice)
{
    int res = 0;
    for (int i = 1; i <= 6; i++)
    {
        int count = 0;
        foreach (int item in dice)
        {
            if (i == item) count++;
        }
        if (count > 2)
        {
            if (i == 1)
            {
                res += 1000;
            }
            else
            {
                res += i * 100;
            }
            if(count== 3)
            {
                continue;
            }
            else
            {
                count -=3;
            }
        }
        if (i == 1)
        {
            res += 100 * count;
        }
        if (i == 5)
        {
            res += 50 * count;
        }
    }

    return res;
}