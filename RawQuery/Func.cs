using System;
using System.Collections.Generic;
using System.Linq;

namespace RawQuery
{
    /// <summary>
    /// Contains some built-in function clauses.
    /// </summary>
    public static class Func
    {
        /// <summary>
        /// Builds a "concat" function clause.
        /// </summary>
        /// <param name="collection">The collection of clauses to concat.</param>
        /// <returns>A "concat" function clause based on the given parameters.</returns>
        public static String Concat(IEnumerable<String> collection)
        {
            var list = Format.List(collection.Where(x => !String.IsNullOrEmpty(x)));
            return $"concat({list})";
        }

        /// <summary>
        /// Builds a "concat" function clause.
        /// </summary>
        /// <param name="collection">The collection of clauses to concat.</param>
        /// <returns>A "concat" function clause based on the given parameters.</returns>
        public static String Concat(params String[] collection)
        {
            return Concat(collection.AsEnumerable());
        }

        /// <summary>
        /// Builds a "concat" function clause.
        /// </summary>
        /// <param name="clause">The clause to put into the concat function.</param>
        /// <returns>A "concat" function clause based on the given parameter.</returns>
        public static String Concat(String clause)
        {
            return $"concat({clause})";
        }

        /// <summary>
        /// Builds a "sum" function clause.
        /// </summary>
        /// <param name="clause">The clause to put into the sum function.</param>
        /// <returns>A "sum" function clause based on the given parameter.</returns>
        public static String Sum(String clause)
        {
            return $"sum({clause})";
        }

        /// <summary>
        /// Builds an "avg" function clause.
        /// </summary>
        /// <param name="clause">The clause to put into the avg function.</param>
        /// <returns>An "avg" function clause based on the given parameter.</returns>
        public static String Avg(String clause)
        {
            return $"avg({clause})";
        }

        /// <summary>
        /// Builds a "count" function clause.
        /// </summary>
        /// <param name="clause">The clause to put into the count function.</param>
        /// <returns>A "count" function clause based on the given parameter.</returns>
        public static String Count(String clause)
        {
            return $"count({clause})";
        }
    }
}
