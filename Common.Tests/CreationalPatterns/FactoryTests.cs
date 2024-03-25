namespace Ksh.Common.Tests.CreationalPatterns;

public class FactoryTests
{
    [Fact] public void Create_WindowsFactory()
    {
        // Arrange
        var sut = new AppFactory();

        // Act
        var button = sut.Create(Os.Windows);

        // Assert
        button.Should().BeOfType(typeof(WindowsFactory));
    }

    [Fact] public void Create_GnomeFactory()
    {
        // Arrange
        var sut = new AppFactory();

        // Act
        var button = sut.Create(Os.Gnome);

        // Assert
        button.Should().BeOfType(typeof(GnomeFactory));
    }
}

