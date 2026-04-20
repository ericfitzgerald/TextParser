using TextParser.FileParser;

class FilterText
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: FilterText [Filename]");
            return;
        }
        
        string filename = args[0];

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File not found: {filename}");
            return;
        }

        var parser = new FileParser(filename);
        var output = parser.Parse();
        var combined = string.Join(" ",output);

        Console.WriteLine(combined);
    }
}