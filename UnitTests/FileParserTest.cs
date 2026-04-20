namespace TextParser.UnitTests;

[TestClass]
public sealed class FileParserTest
{
    private FileParser.FileParser parser = new FileParser.FileParser("SampleText");

    [TestMethod]
    public void Parse_should_match_output()
    {
        // Note, this test acts as an integration test
        var expectedOuput = "beginning and once she reading and use she considering own she and and picking daisies remarkable she she all and and hurried flashed she never and burning she and large under hedge never once considering world she and dipped herself she herself falling she she she and wonder happen she and she she sides and filled and shelves and she and She one shelves she passed she killing one she";

        var output = parser.Parse();
        var combinedOutput = string.Join(" ",output);

        Assert.AreEqual(expectedOuput,combinedOutput);
    }
}
