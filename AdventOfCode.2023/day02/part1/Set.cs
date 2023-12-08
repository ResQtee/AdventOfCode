namespace AdventOfCode._2023.day02.part1;

public class Set
{
    public int NumberOfRedCubes { get; set; }
    public int NumberOfGreenCubes { get; set; }
    public int NumberOfBlueCubes { get; set; }

    public int Power()
    {
        return NumberOfBlueCubes * NumberOfGreenCubes * NumberOfRedCubes;
    }
}