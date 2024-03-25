namespace Ksh.Common.Tests.CreationalPatterns.DomainLang;

interface IControlFactory : IAbstractFactory
{
    ILabel CreateLabel();
    IButton CreateButton();
    IPanel CreatePanel();
    IDialog CreateDialog();
}