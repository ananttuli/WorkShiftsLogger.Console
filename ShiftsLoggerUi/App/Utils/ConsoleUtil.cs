using Spectre.Console;

namespace ShiftsLoggerUi.App.Utils;

public class ConsoleUtil
{
    public static ConsoleKeyInfo PressAnyKeyToClear(string message = "Press any key to continue")
    {
        AnsiConsole.MarkupLine(message);
        var key = Console.ReadKey();
        Console.Clear();

        return key;
    }
}