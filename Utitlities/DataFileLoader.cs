public static class DataFileLoader
{
    private static readonly string path = @"Data\urn-data.txt";

    public static string LoadLine()
    {
        var lines = File.ReadAllLines(path);
        return lines[0];
    }

    public static string LoadAll()
    {
        return File.ReadAllText(path);
    }
}
