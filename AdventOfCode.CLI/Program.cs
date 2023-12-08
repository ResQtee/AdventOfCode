using AdventOfCode._2023.day01;
using AdventOfCode._2023.day01.part1;
using AdventOfCode._2023.day01.part2;
using AdventOfCode._2023.day02.part1;

namespace AdventOfCode.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 2023
            /*
            // day 1:
            // part 1:
            Console.WriteLine("----- Part one -----");
            var calibrationDigitRecovery = new CalibrationDigitRecovery();
            var part1Example = await calibrationDigitRecovery.Sum(@".\day01\input\example1.txt");
            Console.WriteLine($"Sum example 1: {part1Example}");

            var sumPart1 = await calibrationDigitRecovery.Sum(@".\day01\input\input.txt");
            Console.WriteLine($"Sum part 1: {sumPart1}");

            // part 2:
            Console.WriteLine("----- Part two -----");

            var calibrationExtendedDigitRecovery = new CalibrationExtendedDigitRecovery();
            var part2Example = await calibrationExtendedDigitRecovery.Sum(@".\day01\input\example2.txt");
            Console.WriteLine($"Sum example 2: {part2Example}");

            var sumPart2 = await calibrationExtendedDigitRecovery.Sum(@".\day01\input\input.txt");
            Console.WriteLine($"Sum part 2: {sumPart2}");
            */

            // day 2:
            // part 1:
            Console.WriteLine("----- Part one -----");
            var gameParser = new GameParser();
            
            var gameEvaluator = new GameEvaluator();
            var bagExample1 = new Set()
            {
                NumberOfRedCubes = 12,
                NumberOfGreenCubes = 13,
                NumberOfBlueCubes = 14
            };

            var gamesExample1 = await gameParser.GamesFromFile(@".\day02\input\example1.txt");
            var sumExample = gameEvaluator.Sum(gamesExample1, bagExample1);
            Console.WriteLine($"Sum example 1: {sumExample}");

            var gamesInput1 = await gameParser.GamesFromFile(@".\day02\input\input.txt");
            var sumInput1 = gameEvaluator.Sum(gamesInput1, bagExample1);
            Console.WriteLine($"Sum part 1: {sumInput1}");
            
            // part 2
            Console.WriteLine("----- Part two -----");
            var powerExample1 = gameEvaluator.Power(gamesExample1);
            Console.WriteLine($"Power example 1: {powerExample1}");
            
            var powerPart2 = gameEvaluator.Power(gamesInput1);
            Console.WriteLine($"Power part 2: {powerPart2}");
        }
    }
}
