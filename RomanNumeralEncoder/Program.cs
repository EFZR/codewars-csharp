namespace RomanNumeralConverter;

public class RomanConvert
{
    public static string Solution(int n)
    {
        // Define Roman numeral mappings
        var romanNumerals = new (int, string)[]
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        };

        // Convert integer to Roman numeral
        var result = "";
        foreach (var (value, numeral) in romanNumerals)
        {
            while (n >= value)
            {
                result += numeral;
                n -= value;
            }
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        // Testing the solution
        Console.WriteLine(RomanConvert.Solution(1));
        Console.WriteLine(RomanConvert.Solution(2));
        Console.WriteLine(RomanConvert.Solution(4));
        Console.WriteLine(RomanConvert.Solution(500));
        Console.WriteLine(RomanConvert.Solution(1000));
        Console.WriteLine(RomanConvert.Solution(1954));
        Console.WriteLine(RomanConvert.Solution(2008));
        Console.WriteLine(RomanConvert.Solution(2024));
    }
}
