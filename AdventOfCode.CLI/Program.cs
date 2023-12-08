using AdventOfCode._2023.day01;
using AdventOfCode._2023.day01.part1;
using AdventOfCode._2023.day01.part2;

namespace AdventOfCode.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 2023
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
        }
    }
}
