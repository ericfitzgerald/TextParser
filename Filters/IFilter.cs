namespace TextParser.Filters;

public interface IFilter
{
    public bool ShouldFilter(string word);
}