namespace AdventOfCode._2023.day01.part1;

public class CalibrationDigitRecovery : CalibrationValuesRecovery
{
    protected override int RecoverCalibrationValue(string calibrationLine)
    {
        var firstDigit = calibrationLine.First(char.IsNumber);
        var lastDigit = calibrationLine.Last(char.IsNumber);

        var calibrationValue = int.Parse($"{firstDigit}{lastDigit}");
        return calibrationValue;
    }
}