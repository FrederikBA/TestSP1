using Core;

namespace Test;

public class DummyTest
{
    [Fact]
    public void IsDummyTest()
    {
        var dummyService = new DummyService();
        var text = "dummytext";
        var result = dummyService.IsDummy(text);

        Assert.True(result, text + " should be 'dummytext'");
    }
}