using Penguin.Reflection;
using Penguin.Testing.Interfaces;
using System;
using System.Linq;

namespace Penguin.Testing.RuntimeValidation
{
    /// <summary>
    /// Static class used to find and execute runtime validation tests
    /// </summary>
    public static class RuntimeValidator
    {
        #region Methods

        /// <summary>
        /// Finds all runtime validation tests and executes them. Throws an error with the results if unsuccessful.
        /// Used to block program execution if tests fail
        /// </summary>
        public static void ExecuteTests()
        {
            ValidationResults results = ValidateTests();

            if (!results.Success)
            {
                throw new Exception($"Runtime validation failed: \r\n\r\n {string.Join("\r\n", results.Results.Select(r => r.Message))}");
            }
        }

        /// <summary>
        /// Finds all runtime validation tests and executes them, returning the results
        /// </summary>
        /// <returns>The test results</returns>
        public static ValidationResults ValidateTests()
        {
            ValidationResults results = new ValidationResults();

            foreach (Type toRun in TypeFactory.GetAllImplementations(typeof(IRuntimeValidator)))
            {
                IRuntimeValidator thisValidator = (IRuntimeValidator)Activator.CreateInstance(toRun);

                ValidationResults theseResults = thisValidator.Validate();

                results.AddResults(theseResults);
            }

            return results;
        }

        #endregion Methods
    }
}