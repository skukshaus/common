namespace Ksh.Common.Tests.CreationalPatterns.DomainLang;

class WindowsFactory : IControlFactory
{
    public ILabel CreateLabel() => new WindowsLabel();

    public IButton CreateButton() => new WindowsButton();

    public IPanel CreatePanel() => new WindowsPanel();

    public IDialog CreateDialog() => new WindowsDialog();
}