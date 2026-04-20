namespace TextParser.Filters;

public class LengthLessThanThreeFilter : IFilter
{
    public bool ShouldFilter(string word)
    {
        return word.Length < 3;
    }
}
