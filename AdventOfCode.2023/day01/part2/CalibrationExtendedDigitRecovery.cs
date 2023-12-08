namespace AdventOfCode._2023.day01.part2;

public class CalibrationExtendedDigitRecovery : CalibrationValuesRecovery
{
    private readonly Tuple<int, string>[] validDigits = 
    {
        new(1, "1"),
        new(1, "one"),

        new(2, "2"),
        new(2, "two"),

        new(3, "3"),
        new(3, "three"),

        new(4, "4"),
        new(4, "four"),

        new(5, "5"),
        new(5, "five"),

        new(6, "6"),
        new(6, "six"),

        new(7, "7"),
        new(7, "seven"),

        new(8, "8"),
        new(8, "eight"),

        new(9, "9"),
        new(9, "nine"),
    };

    protected override int RecoverCalibrationValue(string calibrationLine)
    {
        var firstDigitIndices = new List<(int Digit, int Index)>(validDigits.Length);
        var lastDigitIndices = new List<(int Digit, int Index)>(validDigits.Length);
        foreach ((int digit, string digitCode) in validDigits)
        {
            firstDigitIndices.Add((digit, calibrationLine.IndexOf(digitCode, StringComparison.OrdinalIgnoreCase)));
            lastDigitIndices.Add((digit, calibrationLine.LastIndexOf(digitCode, StringComparison.OrdinalIgnoreCase)));
        }
        
        var foundDigits = firstDigitIndices.Where(i => i.Index > -1).ToList();
        var firstCalibrationValue = foundDigits.MinBy(i => i.Index).Digit;
        
        foundDigits = lastDigitIndices.Where(i => i.Index > -1).ToList();
        var lastCalibrationValue = foundDigits.MaxBy(i => i.Index).Digit;

        var no = int.Parse($"0{firstCalibrationValue}{lastCalibrationValue}");
        return no;
    }
}