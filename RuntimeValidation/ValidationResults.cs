using System.Collections.Generic;

namespace Penguin.Testing.RuntimeValidation
{
    /// <summary>
    /// A class intended on holding the results of a runtime validation test
    /// </summary>
    public class ValidationResults
    {
        #region Properties

        /// <summary>
        /// A list of the individual validation results for this test
        /// </summary>
        public List<ValidationResult> Results { get; set; } = new List<ValidationResult>();

        /// <summary>
        /// The overall success of the test
        /// </summary>
        public bool Success { get; set; } = true;

        #endregion Properties

        #region Methods

        /// <summary>
        /// Add a new result to the final result list
        /// </summary>
        /// <param name="result">The result to add</param>
        public void AddResult(ValidationResult result)
        {
            this.Success &= result.Success;

            this.Results.Add(result);
        }

        /// <summary>
        /// Adds new ValidationResults to the final result list
        /// </summary>
        /// <param name="results">The results to add</param>
        public void AddResults(ValidationResults results)
        {
            foreach (ValidationResult result in results.Results)
            {
                this.Success &= result.Success;

                this.Results.Add(result);
            }
        }

        #endregion Methods
    }
}