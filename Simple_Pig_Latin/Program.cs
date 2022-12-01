

// test
Console.WriteLine(PigIt("Pig latin is cool"));
Console.WriteLine(PigIt("This is my string"));
Console.WriteLine(PigIt("Hello world !"));


// decision
string PigIt(string str)
  {
    string[] words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = words[i][1..^0] + words[i][0];
        if(words[i] != "!") words[i]+= ((i == words.Length - 1) ? "ay" : "ay ");
        
    }
    str = "";
    foreach (string i in words)
    {
        str += i;
    }

    return str;
  }