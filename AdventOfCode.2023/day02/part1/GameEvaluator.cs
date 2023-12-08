namespace AdventOfCode._2023.day02.part1;

public class GameEvaluator
{
    public int Sum(List<Game> games, Set bag)
    {
        var impossibleGames = games.Where(game => IsPossibleGame(game, bag));
        
        return impossibleGames.Sum(game => game.Id);
    }

    private bool IsPossibleGame(Game game, Set bag)
    {
        return game.Sets.All(set => IsPossible(set,bag));
    }

    private bool IsPossible(Set set, Set bag)
    {
        // There should be more (ore equal) in the bag than shown in the set.
        return bag.NumberOfRedCubes >= set.NumberOfRedCubes
               && bag.NumberOfGreenCubes >= set.NumberOfGreenCubes
               && bag.NumberOfBlueCubes >= set.NumberOfBlueCubes;
    }

    public int Power(List<Game> games)
    {
        var powers = new List<int>(games.Count);
        powers.AddRange(games.Select(CalculatePower));

        return powers.Sum();
    }

    private int CalculatePower(Game game)
    {
        var minimalViableSet = game.MinimalViableSet();
        return minimalViableSet.Power();
    }
}