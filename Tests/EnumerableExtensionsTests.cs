using Lemao.UtilExtensions;

namespace Tests;

public class EnumerableExtensionsTests
{
    [Fact]
    public void When_IsNullOrEmpty_given_empty_list_should_return_true()
    {
        // Act
        var actual = new List<string>().IsNullOrEmpty();

        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void When_IsNullOrEmpty_given_null_should_return_true()
    {
        // Act
        var actual = ((List<string>?)null).IsNullOrEmpty();

        // Assert
        Assert.True(actual);
    }

    [Fact]
    public void When_IsNullOrEmpty_given_non_empty_list_should_return_false()
    {
        // Act
        var actual = new List<string> { "any" }.IsNullOrEmpty();

        // Assert
        Assert.False(actual);
    }

    [Fact]
    public void When_JoinWith_given_strings_should_return_joined_string()
    {
        // Arrange
        var list = new List<string> { "a", "b", "c" };

        // Act
        var actual = list.JoinWith(":");

        // Assert
        Assert.Equal("a:b:c", actual);
    }

    [Fact]
    public void When_ToCommaSeparated_given_strings_should_return_comma_joined_string()
    {
        // Arrange
        var list = new List<string> { "a", "b", "c" };

        // Act
        var actual = list.ToCommaSeparated();

        // Assert
        Assert.Equal("a, b, c", actual);
    }

    [Fact]
    public void When_ToSpaceSeparated_given_strings_should_return_space_joined_string()
    {
        // Arrange
        var list = new List<string> { "a", "b", "c" };

        // Act
        var actual = list.ToSpaceSeparated();

        // Assert
        Assert.Equal("a b c", actual);
    }
}
