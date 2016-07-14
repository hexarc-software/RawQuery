using System;

namespace RawQuery
{
    /// <summary>
    /// Contains sql join clause builders.
    /// </summary>
    public static class Join
    {
        /// <summary>
        /// Builds an "inner join" clause.
        /// </summary>
        /// <param name="what">The argument represents what to join.</param>
        /// <param name="conditions">The join conditions.</param>
        /// <returns>An "inner join" clause based on the given parameters.</returns>
        public static String Inner(String what, String conditions)
        {
            return $"join {what} on {conditions}";
        }

        /// <summary>
        /// Builds a "left join" clause.
        /// </summary>
        /// <param name="what">The argument represents what to join.</param>
        /// <param name="conditions">The join conditions.</param>
        /// <returns>A "left join" clause based on the given parameters.</returns>
        public static String Left(String what, String conditions)
        {
            return $"left join {what} on {conditions}";
        }

        /// <summary>
        /// Builds a "right join" clause.
        /// </summary>
        /// <param name="what">The argument represents what to join.</param>
        /// <param name="conditions">The join conditions.</param>
        /// <returns>A "right join" clause based on the given parameters.</returns>
        public static String Right(String what, String conditions)
        {
            return $"right join {what} on {conditions}";
        }
    }
}
