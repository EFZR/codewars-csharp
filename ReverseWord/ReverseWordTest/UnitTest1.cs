using ReverseWordKata;

namespace ReverseWordTest;

public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual("sihT si na !elpmaxe", ReverseWord.ReverseWords("This is an example!"));
		}
}
