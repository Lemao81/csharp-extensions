using CSharpExtensions;

namespace Tests;

public class ByteArrayExtensionsTests
{
    [Fact]
    public void When_GetString_given_byte_array_should_return_string()
    {
        var actual = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x57, 0x6F, 0x72, 0x6C, 0x64, 0x21 }.GetString();

        Assert.Equal("Hello World!", actual);
    }
    
    [Fact]
    public void When_ToBase64String_given_byte_array_should_return_base64_encoded_string()
    {
        var actual = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x57, 0x6F, 0x72, 0x6C, 0x64, 0x21 }.ToBase64String();

        Assert.Equal("SGVsbG8gV29ybGQh", actual);
    }
}
