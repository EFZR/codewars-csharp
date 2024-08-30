using Solution;

namespace Test;

[TestFixture]
public class Tests
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Class1.Divisor(15), Is.EqualTo(new int[] { 3, 5 }), "n = 15");
            Assert.That(Class1.Divisor(16), Is.EqualTo(new int[] { 2, 4, 8 }), "n = 16");
            Assert.That(Class1.Divisor(253), Is.EqualTo(new int[] { 11, 23 }), "n = 253");
            Assert.That(Class1.Divisor(24), Is.EqualTo(new int[] { 2, 3, 4, 6, 8, 12 }), "n = 24");
            Assert.That(Class1.Divisor(7), Is.EqualTo(null), "n = 7");
        });
    }
}