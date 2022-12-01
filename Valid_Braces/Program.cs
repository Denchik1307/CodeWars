

// test
Console.WriteLine(validBraces("()"));
Console.WriteLine(validBraces("[]"));
Console.WriteLine(validBraces("(){}[]"));
Console.WriteLine(validBraces("([{}])"));
Console.WriteLine(validBraces("([{}])"));
Console.WriteLine(validBraces("[(])"));
Console.WriteLine(validBraces("({})[({})]"));
Console.WriteLine(validBraces("(})"));
Console.WriteLine(validBraces("{}"));
Console.WriteLine(validBraces("(({{[[]]}}))"));
Console.WriteLine(validBraces("{}({})[]"));
Console.WriteLine(validBraces(")(}{]["));
Console.WriteLine(validBraces("())({}}{()][]["));
Console.WriteLine(validBraces("(((({{"));
Console.WriteLine(validBraces("}}]]))}])"));
Console.WriteLine(validBraces("}}()"));


// decision
bool validBraces(String braces)
{
    int count = 0;
    while (braces != "" ^ count == braces.Length * 2)
    {
        count++;
        braces = braces.Replace("()", "").Replace("{}", "").Replace("[]", "");
    }

    return (braces == "") ? true : false;
}