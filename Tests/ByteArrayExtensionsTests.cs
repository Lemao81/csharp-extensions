using CSharpExtensions;

namespace Tests;

public class ByteArrayExtensionsTests
{
    [Fact]
    public void When_GetString_given_byte_array_should_return_string()
    {
        var actual = "Hello World!"u8.ToArray().GetString();

        Assert.Equal("Hello World!", actual);
    }
    
    [Fact]
    public void When_ToBase64String_given_byte_array_should_return_base64_encoded_string()
    {
        var actual = "Hello World!"u8.ToArray().ToBase64String();

        Assert.Equal("SGVsbG8gV29ybGQh", actual);
    }
}
