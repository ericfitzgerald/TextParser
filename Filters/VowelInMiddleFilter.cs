namespace TextParser.Filters;

public class VowelInMiddleFilter : IFilter
{
    public bool ShouldFilter(string word)
    {
        char[] vowels = ['a','e','i','o','u'];

        var middle = GetMiddle(word);

        return middle.ToLower().ToArray().Intersect(vowels).Count() > 0;
    }

    private string GetMiddle(string word)
    {
        int middle = word.Length / 2;
        // for even length words we want 2 letters, otherwise 1
        int length = word.Length % 2 == 0 ? 2 : 1;
        // even length words need to move the middle position back 1
        middle = length == 2 ? middle - 1 : middle;

        return word.Substring(middle,length);
    }
}
