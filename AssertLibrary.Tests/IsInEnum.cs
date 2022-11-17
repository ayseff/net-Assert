namespace AssertLibrary.Tests;

using System;
[TestClass]
public class IsInEnum
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsInEnum<StringSplitOptions>(0);
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsInEnum<StringSplitOptions>(5);
    }
}