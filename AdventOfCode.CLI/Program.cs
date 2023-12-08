using AdventOfCode._2023;

namespace AdventOfCode.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 2023
            // day 1:
            var sumExample1 = await CalibrationValuesRecovery.Sum(@".\day01\input\example1.txt");
            Console.WriteLine($"Sum example 1: {sumExample1}");

            var sumInput1 = await CalibrationValuesRecovery.Sum(@".\day01\input\input.txt");
            Console.WriteLine($"Sum example 1: {sumInput1}");
        }
    }
}
