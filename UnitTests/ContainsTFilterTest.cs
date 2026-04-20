using TextParser.Filters;

namespace TextParser.UnitTests;

[TestClass]
public sealed class ContainsTFilterTest
{
    private ContainsTFilter filter = new ContainsTFilter();

    [TestMethod]
    public void ShouldFilter_returns_true_when_word_contains_upper_T()
    {
        var output = filter.ShouldFilter("True");
        
        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_true_when_word_contains_lower_t()
    {
        var output = filter.ShouldFilter("true");

        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_false_when_word_does_not_contain_t()
    {
        var output = filter.ShouldFilter("happy");

        Assert.IsFalse(output);
    }
}
