using System;
using System.Collections.Generic;
using System.Linq;

namespace RawQuery
{
    /// <summary>
    /// Contains union clauses.
    /// </summary>
    public static class Union
    {
        /// <summary>
        /// Builds a "union all" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to union.</param>
        /// <returns>A "union all" clause based on the given collection.</returns>
        public static String All(IEnumerable<String> clauses)
        {
            var separator = $"{Environment.NewLine}union all{Environment.NewLine}";
            return String.Join(separator, clauses.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds a "union all" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to union.</param>
        /// <returns>A "union all" clause based on the given collection.</returns>
        public static String All(params String[] clauses)
        {
            return All(clauses.AsEnumerable());
        }

        /// <summary>
        /// Builds a "union" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to union.</param>
        /// <returns>A "union" clause based on the given collection.</returns>
        public static String Distinct(IEnumerable<String> clauses)
        {
            var separator = $"{Environment.NewLine}union{Environment.NewLine}";
            return String.Join(separator, clauses.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds a "union" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to union.</param>
        /// <returns>A "union" clause based on the given collection.</returns>
        public static String Distinct(params String[] clauses)
        {
            return Distinct(clauses.AsEnumerable());
        }
    }
}
