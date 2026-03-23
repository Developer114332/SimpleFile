using Xunit;

public class UnitTest1
{
    [Fact]
    public void TestHello()
    {
        Assert.Equal("Hello, World!", Program.Hello());
    }
}
