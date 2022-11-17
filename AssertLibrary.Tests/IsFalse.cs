﻿namespace AssertLibrary.Tests;

[TestClass]
public class IsFalse
{
    [TestMethod]
    public void Valid()
    {
        Assert.IsFalse(false);
    }

    [TestMethod, ExpectedException(typeof(AssertException))]
    public void Invalid()
    {
        Assert.IsFalse(true);
    }
}