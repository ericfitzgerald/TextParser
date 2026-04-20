using System.Text.RegularExpressions;
using TextParser.Filters;

namespace TextParser.FileParser;

public class FileParser
{
    string text = "";
    string fileName;

    public FileParser(string fileName)
    {
        this.fileName = fileName;
    }
    public List<string> Parse()
    {
        text = File.ReadAllText(fileName);

        RemoveApostrophes();
        ConvertSpecialCharactersToSpaces();
        
        return ApplyFilters();
    }

    private void RemoveApostrophes()
    {
        text = text.Replace("'","");
    }

    private void ConvertSpecialCharactersToSpaces()
    {
        text = Regex.Replace(text, "[^\\w]", " ");
    }
    
    private List<string> ApplyFilters()
    {
        IFilter[] filters = [new LengthLessThanThreeFilter(), new ContainsTFilter(), new VowelInMiddleFilter()];
        var filtered = new List<string>();

        var splitText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in splitText)
        {
            bool shouldFilter = false;

            foreach (var filter in filters)
            {
                shouldFilter = filter.ShouldFilter(word);
                if (shouldFilter)
                {
                    break;
                }
            }

            if (!shouldFilter)
            {
                filtered.Add(word);
            }
        }

        return filtered;
    }
}
