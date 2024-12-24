using Tests.Helpers;
using UtilExtensions;

namespace Tests;

public class PropertyInfoExtensionsTests
{
    [Fact]
    public void When_IsEnum_given_non_enum_property_should_return_false()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.StringProperty));
        var actual = property.IsEnum();

        Assert.False(actual);
    }

    [Fact]
    public void When_IsEnum_given_enum_property_should_return_true()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.EnumProperty));
        var actual = property.IsEnum();

        Assert.True(actual);
    }

    [Fact]
    public void When_IsEnumerableOf_given_non_enumerable_property_should_return_false()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.StringProperty));
        var actual = property.IsEnumerableOf(typeof(string));

        Assert.False(actual);
    }

    [Fact]
    public void When_IsEnumerableOf_given_enumerable_property_should_return_true()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.EnumerableProperty));
        var actual = property.IsEnumerableOf(typeof(string));

        Assert.True(actual);
    }

    [Fact]
    public void When_HasAttribute_given_no_attribute_should_return_false()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.StringProperty));
        var actual = property.HasAttribute<TestAttribute>();

        Assert.False(actual);
    }

    [Fact]
    public void When_HasAttribute_given_attribute_should_return_true()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.AttributeProperty));
        var actual = property.HasAttribute<TestAttribute>();

        Assert.True(actual);
    }

    [Fact]
    public void When_TryGetCustomAttribute_given_no_attribute_should_return_false()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.StringProperty));
        var actual = property.TryGetCustomAttribute<TestAttribute>(out var attribute);

        Assert.False(actual);
        Assert.Null(attribute);
    }

    [Fact]
    public void When_TryGetCustomAttribute_given_attribute_should_return_true()
    {
        var property = typeof(TestClass).GetProperty(nameof(TestClass.AttributeProperty));
        var actual = property.TryGetCustomAttribute<TestAttribute>(out var attribute);

        Assert.True(actual);
        Assert.NotNull(attribute);
        Assert.IsType<TestAttribute>(attribute);
    }
}
