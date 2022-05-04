namespace Penguin.Testing.RuntimeValidation.Interfaces
{
    /// <summary>
    /// And interface required to hook into the runtime validation system
    /// </summary>
    public interface IRuntimeValidator
    {
        #region Methods

        /// <summary>
        /// Called when executing or validating tests
        /// </summary>
        /// <returns>The test results</returns>
        ValidationResults Validate();

        #endregion Methods
    }
}