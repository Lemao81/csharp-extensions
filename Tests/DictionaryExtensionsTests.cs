using Lemao.UtilExtensions;

namespace Tests;

public class DictionaryExtensionsTests
{
    [Fact]
    public void When_key_not_exists_Should_add_and_get()
    {
        // Arrange
        var dict = new Dictionary<string, string>();

        // Act
        var actual = dict.GetOrAdd("thekey", "thevalue");

        // Assert
        Assert.Equal("thevalue", actual);
    }

    [Fact]
    public void When_key_exists_Should_get()
    {
        // Arrange
        var dict = new Dictionary<string, string> { { "thekey", "thevalue" } };

        // Act
        var actual = dict.GetOrAdd("thekey", "othervalue");

        // Assert
        Assert.Equal("thevalue", actual);
    }

    [Fact]
    public void When_key_not_exists_Should_return_false()
    {
        // Arrange
        var dict = new Dictionary<string, string>();

        // Act
        var actual = dict.TryUpdate("thekey", "thevalue");

        // Assert
        Assert.False(actual);
    }

    [Fact]
    public void When_key_exists_Should_update_and_return_true()
    {
        // Arrange
        var dict = new Dictionary<string, string> { { "thekey", "thevalue" } };

        // Act
        var actual = dict.TryUpdate("thekey", "othervalue");

        // Assert
        Assert.True(actual);
        Assert.Equal("othervalue", dict["thekey"]);
    }
}
