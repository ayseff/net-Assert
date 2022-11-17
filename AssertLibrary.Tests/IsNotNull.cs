namespace AssertLibrary.Tests;

[TestClass]
public class IsNotNull
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsNotNull(string.Empty);
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsNotNull(null);
    }
}