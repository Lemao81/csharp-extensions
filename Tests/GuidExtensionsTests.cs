using System;
using CSharpExtensions;

namespace Tests;

public class GuidExtensionsTests
{
    [Theory]
    [InlineData("e2d1e8c4-eec4-4010-b020-8cbd6fb13b9a", false)]
    [InlineData("00000000-0000-0000-0000-000000000000", true)]
    public void When_IsEmpty_should_flag_is_empty(string guidString, bool expected)
    {
        var actual = Guid.Parse(guidString).IsEmpty();

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("5842f660-c784-491c-a8c6-6f5ff48f19be", false)]
    [InlineData("00000000-0000-0000-0000-000000000000", true)]
    [InlineData(null, true)]
    public void When_IsNullOrEmpty_should_flag_is_null_or_empty(string guidString, bool expected)
    {
        Guid? guid = string.IsNullOrEmpty(guidString) ? null : Guid.Parse(guidString);
        var actual = guid.IsNullOrEmpty();

        Assert.Equal(expected, actual);
    }
}
