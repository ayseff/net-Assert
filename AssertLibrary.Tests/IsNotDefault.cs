namespace AssertLibrary.Tests;

using System;
[TestClass]
public class IsNotDefault
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsNotDefault(Guid.NewGuid());
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsNotDefault(new Guid());
    }
}