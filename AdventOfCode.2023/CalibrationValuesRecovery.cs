using AdventOfCodeLib;

namespace AdventOfCode._2023
{
    public class CalibrationValuesRecovery
    {
        public static async Task<int> Sum(string filePath)
        {
            // read file
            var inputLines = await InputFileReader.ReadLinesFromFile(filePath);
            
            // Recover calibration values as digits.
            var calibrationValues = RecoverCalibrationValues(inputLines);

            // Sum of all calibration values.
            return calibrationValues.Sum();
        }

        private static IEnumerable<int> RecoverCalibrationValues(IEnumerable<string> calibrationLines)
        {
            return calibrationLines.Select(RecoverCalibrationValue).AsParallel();
        }

        private static int RecoverCalibrationValue(string calibrationLine)
        {
            var firstDigit = calibrationLine.First(char.IsNumber);
            var lastDigit = calibrationLine.Last(char.IsNumber);

            var no = int.Parse($"{firstDigit}{lastDigit}");
            return no;
        }
    }
}
