using KLib.Classes;

namespace KLib.Messages;

public class KThemeChangedMessage
{
    internal KTheme NewTheme { get; }

    internal KThemeChangedMessage(KTheme newTheme)
    {
        NewTheme = newTheme;
    }
}