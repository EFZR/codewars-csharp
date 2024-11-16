namespace FindTheOddInt;

public static class FindTheOddIntSolution
{
    public static int findOddSolution(int[] seq)
    {
		for(int i = 0; i < seq.Length; i++)
		{
			var result = seq.Select((n, index) => seq[i] = n).ToList();
			if (result.Count % 2 == 0)
			{
				return seq[i];
			}
		}
        return -1;
    }
}


class Program
{
    static void Main()
    {
        // This should return 4
        Console.WriteLine(FindTheOddIntSolution.findOddSolution([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]));
    }
}
