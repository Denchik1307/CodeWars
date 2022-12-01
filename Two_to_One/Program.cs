

// test
Console.WriteLine(Longest("aretheyhere", "yestheyarehere"));
Console.WriteLine(Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
Console.WriteLine(Longest("inmanylanguages", "theresapairoffunctions"));
Console.WriteLine(Longest("lordsofthefallen", "gamekult"));
Console.WriteLine(Longest("codewars", "codewars"));
Console.WriteLine(Longest("agenerationmustconfrontthelooming", "codewarrs"));


// deciion
string Longest (string s1, string s2) => string.Concat((s1 + s2).ToLower().Distinct().OrderBy(x => x));
    