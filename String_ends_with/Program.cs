

// test
Console.WriteLine(Solution("samurai", "ai"));
Console.WriteLine(Solution("sumo", "omo"));
Console.WriteLine(Solution("ninja", "ja"));
Console.WriteLine(Solution("sensei", "i"));
Console.WriteLine(Solution("samurai", "ra"));
Console.WriteLine(Solution("abc", "abcd"));
Console.WriteLine(Solution("abc", "abc"));
Console.WriteLine(Solution("abcabc", "bc"));
Console.WriteLine(Solution("ails", "fails"));
Console.WriteLine(Solution("fails", "ails"));
Console.WriteLine(Solution("this", "fails"));
Console.WriteLine(Solution("abc", ""));
Console.WriteLine(Solution(":-)", ":-("));
Console.WriteLine(Solution("!@#$%^&*() :-)", ":-)"));
Console.WriteLine(Solution("abc\n", "abc"));


// decision
bool Solution(string str, string ending)
{
    if (str.Length < ending.Length)
    {
        return false;
    }
    else
    {
        return str[(str.Length - ending.Length)..] == ending;
    }
}