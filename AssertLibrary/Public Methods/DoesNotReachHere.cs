namespace AssertLibrary;

public static partial class Assert
{
    /// <summary>
    /// Throws <see cref="ShouldNotReachHereException"/>.
    /// </summary>
    /// <exception cref="ShouldNotReachHereException">Always</exception>
    public static void DoesNotReachHere()
    {
        throw new ShouldNotReachHereException();
    }
}