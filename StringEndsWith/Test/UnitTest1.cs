using Solution;

namespace Test;

[TestFixture]
public class Tests
{
    private static readonly object[] sampleTestCases =
    [
        new object[] {"samurai", "ai", true},
        new object[] {"sumo", "omo", false},
        new object[] {"ninja", "ja", true},
        new object[] {"sensei", "i", true},
        new object[] {"samurai", "ra", false},
        new object[] {"abc", "abcd", false},
        new object[] {"abc", "abc", true},
        new object[] {"abcabc", "bc", true},
        new object[] {"ails", "fails", false},
        new object[] {"fails", "ails", true},
        new object[] {"this", "fails", false},
        new object[] {"abc", "", true},
        new object[] {":-)", ":-(", false},
        new object[] {"!@#$%^&*() :-)", ":-)", true},
        new object[] {"abc\n", "abc", false},
    ];

    [Test, TestCaseSource(nameof(sampleTestCases))]
    public void Test1(string str, string ending, bool expected)
    {
        Assert.That(Class1.Solution(str, ending), Is.EqualTo(expected));
    }
}
