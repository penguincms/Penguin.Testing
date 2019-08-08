namespace Penguin.Testing
{
    /// <summary>
    /// The overall result of the test being run
    /// </summary>
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public enum TestResultStatus
    {
        Pass,
        Fail,
        Error,
        InvalidTest
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}