using KLib.Classes;
using KLib.Messages;
using MessagePipe;

namespace KLib.Services;

internal interface ISessionService : IDisposable
{
    internal KTheme GetCurrentTheme();

    internal void SetCurrentTheme(KTheme theme);
}

internal class SessionService : ISessionService
{
    private KTheme _currentTheme;
    private readonly IDisposable _themeChangedSubscription;

    public SessionService(ISubscriber<KThemeChangedMessage> subscriber)
    {
        _themeChangedSubscription = subscriber.Subscribe(x =>
        {
            ((ISessionService)this).SetCurrentTheme(x.NewTheme);
        });
    }

    KTheme ISessionService.GetCurrentTheme()
    {
        return _currentTheme;
    }

    void ISessionService.SetCurrentTheme(KTheme theme)
    {
        _currentTheme = theme;
    }

    public void Dispose()
    {
        _themeChangedSubscription.Dispose();
    }
}