using System;

namespace Penguin.Testing
{
    /// <summary>
    /// Defines metadata used to help display test results
    /// </summary>
    public class TestDefinitionAttribute : Attribute
    {
        #region Properties

        /// <summary>
        /// The human readable name of the test
        /// </summary>
        public string DisplayName { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a new instance of this test definition
        /// </summary>
        /// <param name="displayName">The human readable name of the test</param>
        public TestDefinitionAttribute(string displayName)
        {
            this.DisplayName = displayName;
        }

        #endregion Constructors
    }
}