
// test
Console.WriteLine(SpinWords("Hey wollef sroirraw"));


// decision
string SpinWords(string sentence)
{
    string[] tmp = sentence.Split(" ");
    int index =0;
    foreach (string item in tmp)
    {
        if(item.Length>4)tmp[index] = new string(item.Reverse().ToArray());
        index++;
    }
    return String.Join(" ",tmp);
}