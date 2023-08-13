using CSharpExtensions;

namespace Tests;

public class StringExtensionsTests
{
    [Theory]
    [InlineData("any", false)]
    [InlineData("  ", false)]
    [InlineData("", true)]
    [InlineData(null, true)]
    public void When_IsNullOrEmpty_should_flag_is_null_or_empty(string str, bool expected)
    {
        var actual = str.IsNullOrEmpty();

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("any", false)]
    [InlineData("  ", true)]
    [InlineData("", true)]
    [InlineData(null, true)]
    public void When_IsNullOrWhiteSpace_should_flag_is_null_or_whitespace(string str, bool expected)
    {
        var actual = str.IsNullOrWhiteSpace();

        Assert.Equal(expected, actual);
    }
}
