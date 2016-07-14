using System;

namespace RawQuery
{
    /// <summary>
    /// Contains brackets clauses.
    /// </summary>
    public static class Brackets
    {
        /// <summary>
        /// Adds round brackets around a clause.
        /// </summary>
        /// <param name="clause">The clause to put in brackets.</param>
        /// <returns>A clause in brackets.</returns>
        public static String Round(String clause)
        {
            return $"({clause})";
        }

        /// <summary>
        /// Adds square brackets around a clause.
        /// </summary>
        /// <param name="clause">The clause to put in brackets.</param>
        /// <returns>A clause in brackets.</returns>
        public static String Square(String clause)
        {
            return $"[{clause}]";
        }

        /// <summary>
        /// Adds curly brackets around a clause.
        /// </summary>
        /// <param name="clause">The clause to put in brackets.</param>
        /// <returns>A clause in brackets.</returns>
        public static String Curly(String clause)
        {
            return $"{{{clause}}}";
        }

        /// <summary>
        /// Adds angle brackets around a clause.
        /// </summary>
        /// <param name="clause">The clause to put in brackets.</param>
        /// <returns>A clause in brackets.</returns>
        public static String Angle(String clause)
        {
            return $"<{clause}>";
        }
    }
}
