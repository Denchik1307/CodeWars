

// test
Console.WriteLine(String.Join(" ",TwoSum(new [] { 1, 2, 3 }, 4)));
Console.WriteLine(String.Join(" ",TwoSum(new [] { 1234, 5678, 9012 }, 14690)));
Console.WriteLine(String.Join(" ",TwoSum(new [] { 2, 2, 3 }, 4)));

// decision
int[] TwoSum(int[] numbers, int target)
  {
    int length = numbers.Length;
     for (int i = 0; i < length; i++)
         for (int j = i + 1; j < length; j++)
             if (numbers[i] + numbers[j] == target)
             {
                return new int[]{i,j};
             }
                
     return new int[0];
  }