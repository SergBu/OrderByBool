// See https://aka.ms/new-console-template for more information
using OrderByBool;
using System;
using System.Linq;

public static class Test
{
    public static void Main()
    {
        var data = new[]
        {
            new { x = false, y = 1 },
            new { x = true, y = 2 },
            new { x = false, y = 3 },
            new { x = true, y = 4 }
        };

        var query = from d in data
                    orderby d.x, d.y
                    select d;

        foreach (var result in query)
        {
            Console.WriteLine(result);
        }

        var list = new List<TestClass>();
        var sum = list.Sum(p => p.y);
        Console.WriteLine(sum);

    }

}
