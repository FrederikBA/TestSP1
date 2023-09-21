using Core;

namespace Test;

public class DummyTest
{
    [Fact]
    public void IsDummyTest()
    {
        var dummyService = new DummyService();
        var result = dummyService.IsDummy("dummytext");

        Assert.True(result);
    }
}