using System.Linq;

// test 
Console.WriteLine(String.Join(",", ArrayDiff(new int[] { 1, 2, 3, 3, 2, 3, 4, 3, 2, 1, 2, 3, 4, 5, 6, }, new int[] { 2, 5 })));



// decision
int[] ArrayDiff(int[] a, int[] b) => a.Where(s=> !b.Contains(s)).ToArray();
