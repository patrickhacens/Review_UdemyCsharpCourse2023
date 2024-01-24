public class StringTextualRepository : StringRepository
{
    private static readonly string Seperator = Environment.NewLine;

    protected override string StringsToText(List<string> content) =>

        string.Join(Seperator, content);


    protected override List<string> TextToStrings(string fileContent) =>
        fileContent.Split(Seperator).ToList();
}