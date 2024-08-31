namespace Solution;

public class Class1
{
    public static bool Solution(string str, string ending)
    {
        return str.Length > ending.Length && str[^ending.Length..] == ending;
    }
}
