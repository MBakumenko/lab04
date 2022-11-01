namespace lab41;

public class color : value
{
    internal override void WriteInDebug(string stringParam, int intParam)
    {
        var prevColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("String Parameter: " + stringParam.GetType());

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("String Parameter: " + intParam.GetType());

        Console.ForegroundColor = prevColor;
    }
}