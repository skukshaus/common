namespace Ksh.Common.Tests.CreationalPatterns.DomainLang;

class AppFactory : IFactory<IControlFactory, Os>
{
    public IControlFactory Create(Os os)
        => os switch {
            Os.Windows => new WindowsFactory(),
            Os.Gnome => new GnomeFactory(),
            _ => throw new NotSupportedException()
        };
}