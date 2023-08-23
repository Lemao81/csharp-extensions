using System.Collections.Generic;
using CSharpExtensions;

namespace Tests;

public class EnumerableExtensionsTests
{
    [Fact]
    public void When_IsNullOrEmpty_given_empty_list_should_return_true()
    {
        var actual = new List<string>().IsNullOrEmpty();

        Assert.True(actual);
    }

    [Fact]
    public void When_IsNullOrEmpty_given_null_should_return_true()
    {
        var actual = ((List<string>)null).IsNullOrEmpty();

        Assert.True(actual);
    }

    [Fact]
    public void When_IsNullOrEmpty_given_non_empty_list_should_return_false()
    {
        var actual = new List<string> { "any" }.IsNullOrEmpty();

        Assert.False(actual);
    }

    [Fact]
    public void When_JoinWith_given_strings_should_return_joined_string()
    {
        var list = new List<string> { "a", "b", "c" };
        var actual = list.JoinWith(":");

        Assert.Equal("a:b:c", actual);
    }

    [Fact]
    public void When_ToCommaSeparated_given_strings_should_return_comma_joined_string()
    {
        var list = new List<string> { "a", "b", "c" };
        var actual = list.ToCommaSeparated();

        Assert.Equal("a, b, c", actual);
    }

    [Fact]
    public void When_ToSpaceSeparated_given_strings_should_return_space_joined_string()
    {
        var list = new List<string> { "a", "b", "c" };
        var actual = list.ToSpaceSeparated();

        Assert.Equal("a b c", actual);
    }
}
