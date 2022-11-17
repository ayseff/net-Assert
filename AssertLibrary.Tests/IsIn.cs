namespace AssertLibrary.Tests;

[TestClass]
public class IsIn
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsIn(3, new[] { 1, 2, 3, });
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsIn(3, new[] { 1, 2, });
    }
}