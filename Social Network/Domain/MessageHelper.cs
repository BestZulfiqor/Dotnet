using Domain.Enum;

namespace Domain;

public static class MessageHelper
{
    public static string FormatMessage(string author, string text, UserStatus status)
    {
        return $"[{status}] {author}: {text}";
    }

    public static bool IsValidMessage(string message)
    {
        return !string.IsNullOrWhiteSpace(message);
    }

    public static string GetCurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }

    public static void ShowColoredMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}