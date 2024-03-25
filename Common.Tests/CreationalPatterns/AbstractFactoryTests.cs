namespace Ksh.Common.Tests.CreationalPatterns;

public class AbstractFactoryTests
{
    [Fact] public void Create_WindowsControls()
    {
        using var _ = new AssertionScope();
        var sut = new AppFactory().Create(Os.Windows);

        sut.CreateButton().Should().BeOfType<WindowsButton>();
        sut.CreatePanel().Should().BeOfType<WindowsPanel>();
        sut.CreateLabel().Should().BeOfType<WindowsLabel>();
        sut.CreateDialog().Should().BeOfType<WindowsDialog>();
    }

    [Fact] public void Create_GnomeControls()
    {
        using var _ = new AssertionScope();
        var sut = new AppFactory().Create(Os.Gnome);

        sut.CreateButton().Should().BeOfType<GnomeButton>();
        sut.CreatePanel().Should().BeOfType<GnomePanel>();
        sut.CreateLabel().Should().BeOfType<GnomeLabel>();
        sut.CreateDialog().Should().BeOfType<GnomeDialog>();
    }
}