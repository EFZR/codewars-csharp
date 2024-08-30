namespace Solution;

public class Class1
{
    public static int[] Divisor(int n)
    {
        List<int> result = [];

        for (int x = 2; x < n; x++)
        {
            if (n % x == 0)
            {
                result.Add(x);
            }
        }

        return result.Count > 0 ? [.. result] : null!;
    }

    public static int[] Divisor2(int n)
    {
        var div = Enumerable.Range(2, (int)Math.Sqrt(n))
            .Where(x => n % x == 0 && x < n)
            .SelectMany(x => new[] { x, n / x })
            .OrderBy(x => x)
            .Distinct()
            .ToArray();

        return div.Length != 0 ? div : null!;
    }
}
