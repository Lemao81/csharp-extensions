using Lemao.UtilExtensions;

namespace Tests;

public class StreamExtensionsTests
{
    [Fact]
    public void When_ToByteArray_given_stream_with_content_should_create_byte_array()
    {
        // Arrange
        var fileStream = new FileStream(Path.Combine("Files", "file.txt"), FileMode.Open);

        // Act
        var bytes = fileStream.ToByteArray();

        // Assert
        Assert.NotEmpty(bytes);
        Assert.Equal("Hello World!"u8.ToArray(), bytes);
    }
}
