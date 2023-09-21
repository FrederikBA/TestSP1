namespace Core;

public class DummyService
{
    public bool IsDummy(string text)
    {
        if (text.Equals("dummytext"))
        {
            return true;
        }
        return false;
    }
}