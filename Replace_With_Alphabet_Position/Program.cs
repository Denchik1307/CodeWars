

// test 
Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));
Console.WriteLine(AlphabetPosition("-.-'"));



// decision
string AlphabetPosition(string text)
{
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    text = text.ToLower();
    int pos;
    string result = string.Empty;
    foreach (char item in text)
    {
        pos = alphabet.IndexOf(item);
        if (pos > -1)
            result += $"{pos + 1} ";
    }

    return result.TrimEnd();
}