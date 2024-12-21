using KLib.Classes;

namespace KLib.Messages;

internal class KThemeChangedMessage
{
    internal KTheme NewTheme { get; }

    internal KThemeChangedMessage(KTheme newTheme)
    {
        NewTheme = newTheme;
    }
}