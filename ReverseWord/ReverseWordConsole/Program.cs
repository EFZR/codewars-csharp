using System.Linq;

namespace ReverseWordKata;

public class ReverseWord
{
    public static string ReverseWords(string str)
    {
        var words = str.Split(" ");
        var reaverseWords = words.Select(w => new string(w.Reverse().ToArray()));
        return string.Join(" ", reaverseWords);
    }
}

class Program
{
    static void Main()
    {
        // Testing the solution
        Console.WriteLine(ReverseWord.ReverseWords("This is an example!"));
    }
}
