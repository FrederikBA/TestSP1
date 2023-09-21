using Core;

namespace Test;

public class DummyTest
{
    [Fact]
    public void IsDummyTest()
    {
        var dummyService = new DummyService();
        var expected = "dummytext";
        var actual = dummyService.IsDummy(expected);

        Assert.True(actual, expected + " should be 'dummytext'");
    }
}