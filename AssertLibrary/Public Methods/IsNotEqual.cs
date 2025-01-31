﻿namespace AssertLibrary;

using System;
using System.Diagnostics;
using System.Globalization;

public static partial class Assert
{
    /// <summary>
    /// Asserts that the given objects are not equal.
    /// </summary>
    /// <param name="one">Object to check</param>
    /// <param name="another">The other object to check</param>
    /// <param name="variableName">Variable name to include in the error message (optional)</param>
    public static void IsNotEqual(object one, object another, string variableName = null)
    {
        if (one == null)
            throw new ArgumentNullException(nameof(one));

        if (another == null)
            throw new ArgumentNullException(nameof(another));

        Check(!one.Equals(another), IsNotEqualMessage(variableName));
    }

    private static string IsNotEqualMessage(string variableName)
    {
        return variableName == null ?
            string.Format(CultureInfo.CurrentCulture, "Should be equal at this point.") :
            string.Format(CultureInfo.CurrentCulture, "\"{0}\" should be equal at this point.", variableName);
    }
}