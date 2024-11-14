namespace CreditCardMaskConsole;

public class CreditCard
{
    public static string CreditCardMask(string str)
    {
        // return str.Length < 4
        //             ? str
        //             : String.Concat(str.ToCharArray().Select((c, index) => index < str.Length - 4 ? '#' : c));

        return str.Length < 4
             ? str
             : str.Substring(str.Length - 4).PadLeft(str.Length, '#');

    }
}

class Program
{
    static void Main()
    {
        // Testing the solution
        Console.WriteLine(CreditCard.CreditCardMask("35616"));
    }
}
