using System;

namespace Penguin.Testing
{
    /// <summary>
    /// A small class used to hold data returned from unit tests
    /// </summary>
    public class TestResult
    {
        #region Properties

        /// <summary>
        /// The display name of the test
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Any exception that caused the test to fail
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The end result of the test
        /// </summary>
        public TestResultStatus Status { get; set; }

        #endregion Properties
    }
}