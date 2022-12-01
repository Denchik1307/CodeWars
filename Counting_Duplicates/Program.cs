// using System.Collections.Generic;
// using System.Linq;

// test
Console.WriteLine(DuplicateCount(""));
Console.WriteLine(DuplicateCount("abcde"));
Console.WriteLine(DuplicateCount("aabbcde"));
Console.WriteLine(DuplicateCount("aabBcde"));
Console.WriteLine(DuplicateCount("Indivisibility"));
Console.WriteLine(DuplicateCount("Indivisibilities"));


// decision
int DuplicateCount(string str) => str.ToLower().GroupBy(i => i).Count(j => j.Count() > 1);