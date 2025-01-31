﻿namespace AssertLibrary;

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;

public static partial class Assert
{
    /// <summary>
    /// Asserts that the given collection have exactly one element.
    /// </summary>
    /// <param name="collection">Collection to check</param>
    /// <param name="variableName">Variable name to include in the error message (optional)</param>
    public static void IsSingle(IEnumerable collection, string variableName = null)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        Check(Count(collection) == 1, IsSingleMessage(variableName));
    }

    private static string IsSingleMessage(string variableName)
    {
        return variableName == null ?
            "Shouldn't be single at this point." :
            string.Format(CultureInfo.CurrentCulture, "\"{0}\" shouldnt't be single at this point.", variableName);
    }
}