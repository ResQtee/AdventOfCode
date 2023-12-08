using AdventOfCodeLib;

namespace AdventOfCode._2023.day02.part1;

public class GameParser
{
    public async Task<List<Game>> GamesFromFile(string filename)
    {
        var gameLines = await InputFileReader.ReadLinesFromFile(filename);

        return gameLines.Select(ParseGame).ToList();
    }

    private Game ParseGame(string gameLine)
    {
        var game = new Game();
        var idString = gameLine[gameLine.IndexOf(" ")..gameLine.IndexOf(":")].Trim();
        game.Id = int.Parse(idString);
        var setsString = gameLine[(gameLine.IndexOf(":")+1)..].Trim();
        game.Sets = ParseSets(setsString);

        return game;
    }

    private List<Set> ParseSets(string setsLine)
    {
        var setsString = setsLine.Split(";");
        return setsString.Select(setString => ParseSet(setString.Trim())).ToList();
    }

    private Set ParseSet(string setString)
    {
        var set = new Set();

        var cubeSet = setString.Split(',', StringSplitOptions.TrimEntries);

        foreach (var cubes in cubeSet)
        {
            var no = cubes[..cubes.IndexOf(" ")];
            var numberOfCubes = int.Parse(no);

            if (cubes.Contains("red", StringComparison.OrdinalIgnoreCase))
            {
                set.NumberOfRedCubes = numberOfCubes;
            }
            else if(cubes.Contains("green", StringComparison.OrdinalIgnoreCase))
            {
                set.NumberOfGreenCubes = numberOfCubes;
            }
            else if (cubes.Contains("blue", StringComparison.OrdinalIgnoreCase))
            {
                set.NumberOfBlueCubes = numberOfCubes;
            }
        }

        return set;
    }
}