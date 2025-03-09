using Lemao.UtilExtensions;

namespace Tests;

public class EnvironmentVariableTests
{
    [Theory]
    [InlineData("true", true)]
    [InlineData("True", true)]
    [InlineData("false", false)]
    [InlineData("nottrue", false)]
    [InlineData("", false)]
    [InlineData("1", true)]
    [InlineData("0", false)]
    [InlineData("001", true)]
    public void When_IsTrue_given_variable_should_return_true_or_false(string value, bool expected)
    {
        // Arrange
        Environment.SetEnvironmentVariable("key", value);

        // Act
        var actual = EnvironmentVariable.IsTrue("key");

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("false", true)]
    [InlineData("False", true)]
    [InlineData("true", false)]
    [InlineData("notfalse", false)]
    [InlineData("", false)]
    [InlineData("1", false)]
    [InlineData("0", true)]
    [InlineData("000", true)]
    public void When_IsFalse_given_variable_should_return_true_or_false(string value, bool expected)
    {
        // Arrange
        Environment.SetEnvironmentVariable("key", value);

        // Act
        var actual = EnvironmentVariable.IsFalse("key");

        // Assert
        Assert.Equal(expected, actual);
    }
}
