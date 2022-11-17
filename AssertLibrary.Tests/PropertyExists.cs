namespace AssertLibrary.Tests;

[TestClass]
public class PropertyExists
{
    [TestMethod]
    public void Valid()
    {
        Assert.PropertyExists(new { Foo = "Bar" }, "Foo");
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.PropertyExists(new { Foo = "Bar" }, "Qux");
    }
}