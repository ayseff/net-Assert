namespace AssertLibrary.Tests;

[TestClass]
public class IsSingle
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsSingle(new[] { 1, });
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsSingle(new[] { 1, 2, });
    }
}