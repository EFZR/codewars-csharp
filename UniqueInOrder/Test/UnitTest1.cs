using Solution;

namespace Test;

[TestFixture]
public class Tests
{
    [Test]
    public void EmptyTest()
    {
        Assert.That(Class1.UniqueInOrder(""), Is.EqualTo(""));
    }
    [Test]
    public void Test1()
    {
        Assert.That(Class1.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
}