namespace Ksh.Common.Tests.CreationalPatterns.DomainLang;

class GnomeFactory : IControlFactory
{
    public ILabel CreateLabel() => new GnomeLabel();

    public IButton CreateButton() => new GnomeButton();

    public IPanel CreatePanel() => new GnomePanel();

    public IDialog CreateDialog() => new GnomeDialog();
}