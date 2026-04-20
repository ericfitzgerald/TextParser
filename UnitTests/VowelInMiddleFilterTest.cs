using TextParser.Filters;

namespace TextParser.UnitTests;

[TestClass]
public sealed class VowelInMiddleFilterTest
{
    private VowelInMiddleFilter filter = new VowelInMiddleFilter();

    [TestMethod]
    public void ShouldFilter_returns_true_when_word_is_odd_length_and_contains_vowel_in_middle()
    {
        var output = filter.ShouldFilter("slice");
        
        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_true_when_word_is_even_length_and_contains_vowel_at_beggining_of_middle()
    {
        var output = filter.ShouldFilter("turn");

        Assert.IsTrue(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_true_when_word_is_even_length_and_contains_vowel_at_end_of_middle()
    {
        var output = filter.ShouldFilter("true");

        Assert.IsTrue(output);
    }

        [TestMethod]
    public void ShouldFilter_returns_false_when_word_is_odd_length_and_does_not_contain_vowel_in_middle()
    {
        var output = filter.ShouldFilter("happy");
        
        Assert.IsFalse(output);
    }

    [TestMethod]
    public void ShouldFilter_returns_false_when_word_is_even_length_and_does_not_contain_vowel_in_middle()
    {
        var output = filter.ShouldFilter("middle");

        Assert.IsFalse(output);
    }
}
