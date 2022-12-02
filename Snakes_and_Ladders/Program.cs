using System.Linq;
bool isPlayer1 = true;
int valOne = 0;
int valTwo = 0;
// test
for (var i = 0; i < 150; i++)
{
    Random ran = new Random();
    int var1 = ran.Next(1, 6);
    int var2 = ran.Next(1, 6);
    string result = play(var1, var2);
    Console.WriteLine(result);
}


// decision


string play(int die1, int die2)
{
    int player = isPlayer1 ? 1 : 2;
    int posLast = isPlayer1 ? valOne : valTwo;
    int point = (posLast + die1 + die2);
    int result = 0;

    if (point > 100) point = 100 - point % 100;

    result = (point) switch
    {
        2 => 38,
        7 => 14,
        8 => 31,
        15 => 26,
        21 => 42,
        28 => 84,
        36 => 44,
        51 => 67,
        71 => 91,
        78 => 98,
        87 => 94,
        16 => 6,
        46 => 25,
        49 => 11,
        62 => 19,
        64 => 60,
        74 => 53,
        89 => 68,
        92 => 88,
        95 => 75,
        99 => 80,
        _ => point
    };

    if (isPlayer1) valOne = result;
    if (!isPlayer1) valTwo = result;

    if (die1 != die2) isPlayer1 = !isPlayer1;

    return result == 100 ? $"Player {player} Wins!" : $"Player {player} is on square {result}";
}
