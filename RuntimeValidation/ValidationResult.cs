using System;

namespace Penguin.Testing.RuntimeValidation
{
    /// <summary>
    /// A class intended on representing a single validation result
    /// </summary>
    public class ValidationResult
    {
        #region Properties

        /// <summary>
        /// The class/type that this test was intended to validate
        /// </summary>
        public Type Checked { get; set; }

        /// <summary>
        /// Any message relevant to the test
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// A bool representing whether or not the test was successful
        /// </summary>
        public bool Success { get; set; }

        #endregion Properties
    }
}