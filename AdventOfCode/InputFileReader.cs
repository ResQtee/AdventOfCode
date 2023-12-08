namespace AdventOfCodeLib
{
    public class InputFileReader
    {
        public static async Task<string[]> ReadLinesFromFile(string path)
        {
            return await File.ReadAllLinesAsync(path);
        }
    }
}
