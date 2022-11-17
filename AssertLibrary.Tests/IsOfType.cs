namespace AssertLibrary.Tests;

[TestClass]
public class IsOfType
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsOfType(typeof(object), 1);
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsOfType(typeof(string), 1);
    }
}