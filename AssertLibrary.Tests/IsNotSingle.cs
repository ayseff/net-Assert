﻿namespace AssertLibrary.Tests;

[TestClass]
public class IsNotSingle
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsNotSingle(new int[] { });
        Assert.IsNotSingle(new[] { 1, 2, });
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsNotSingle(new[] { 1, });
    }
}