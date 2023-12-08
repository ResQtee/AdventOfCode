namespace AdventOfCode._2023.day02.part1;

public class Game
{
    public int Id { get; set; }
    public List<Set> Sets { get; set; }

    public Set MinimalViableSet()
    {   
        return new Set()
        {
            NumberOfRedCubes = Sets.Max(set => set.NumberOfRedCubes),
            NumberOfGreenCubes = Sets.Max(set => set.NumberOfGreenCubes),
            NumberOfBlueCubes = Sets.Max(set => set.NumberOfBlueCubes),
        };
    }
}