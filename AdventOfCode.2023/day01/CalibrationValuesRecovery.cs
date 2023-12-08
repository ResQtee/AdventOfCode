using AdventOfCodeLib;

namespace AdventOfCode._2023.day01
{
    public abstract class CalibrationValuesRecovery
    {
        public async Task<int> Sum(string filePath)
        {
            // read file
            var inputLines = await InputFileReader.ReadLinesFromFile(filePath);
            
            // Recover calibration values as digits.
            var calibrationValues = RecoverCalibrationValues(inputLines);

            //Console.WriteLine(string.Join(',', calibrationValues));

            // Sum of all calibration values.
            return calibrationValues.Sum();
        }

        private IEnumerable<int> RecoverCalibrationValues(IEnumerable<string> calibrationLines)
        {
            return calibrationLines.Select(RecoverCalibrationValue).AsParallel();
        }

        protected abstract int RecoverCalibrationValue(string calibrationLine);
    }
}
