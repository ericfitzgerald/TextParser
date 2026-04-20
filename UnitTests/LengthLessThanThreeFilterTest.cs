using TextParser.Filters;

namespace TextParser.UnitTests;

[TestClass]
public sealed class LengthLessThanThreeFilterTest
{
    private LengthLessThanThreeFilter filter = new LengthLessThanThreeFilter();

    [TestMethod]
    public void ShouldFilter_returns_when_true_length_is_2()
    {
        var output = filter.ShouldFilter("at");
        
        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_true_when_legnth_is_1()
    {
        var output = filter.ShouldFilter("a");

        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_false_when_length_greater_than_2()
    {
        var output = filter.ShouldFilter("yes");

        Assert.IsFalse(output);
    }
}
