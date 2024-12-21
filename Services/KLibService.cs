using KLib.Classes;
using KLib.Messages;
using MessagePipe;

namespace KLib.Services;

public interface IKLibService
{
    public void SetTheme(KTheme theme);
}
public class KLibService : IKLibService
{
    private readonly IPublisher<KThemeChangedMessage> _kThemeChangedPublisher;
    private KTheme _currentTheme;

    internal KLibService(IPublisher<KThemeChangedMessage> kThemeChangedPublisher)
    {
        _kThemeChangedPublisher = kThemeChangedPublisher;
    }

    public void SetTheme(KTheme theme)
    {
        _currentTheme = theme;
        _kThemeChangedPublisher.Publish(new KThemeChangedMessage(theme));
    }
}