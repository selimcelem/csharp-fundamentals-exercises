using System;
using System.Globalization;
using System.Linq;

class LeetCodeProblem
{
static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        var query = nums
            .SelectMany((num1, j) => nums.Select((num2, i) => new { n1 = num1, n2 = num2, i = i, j = j }))
            .Where(x => x.n1 + x.n2 == target && x.i < x.j);

        foreach (var x in query)
            Console.WriteLine(x.n1 + " and " + x.n2 + " occur at "+ x.i + "," + x.j);
    }
}

