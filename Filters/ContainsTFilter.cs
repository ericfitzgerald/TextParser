namespace TextParser.Filters;

public class ContainsTFilter : IFilter
{
    public bool ShouldFilter(string word)
    {
        return word.ToLower().Contains('t');
    }
}
