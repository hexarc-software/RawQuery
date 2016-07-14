using System;

namespace RawQuery
{
    /// <summary>
    /// Contains most general sql clauses.
    /// </summary>
    public static class Clause
    {
        /// <summary>
        /// Builds a "select" clause.
        /// </summary>
        /// <param name="clause">The clause to select.</param>
        /// <returns>A "select" clause based on the given statement.</returns>
        public static String Select(String clause)
        {
            return $"select {clause}";
        }

        /// <summary>
        /// Builds a "select" clause.
        /// </summary>
        /// <param name="what">The clause represents what to select.</param>
        /// <param name="from">The clause to select from.</param>
        /// <returns>A "select" clause based on the given parameters.</returns>
        public static String Select(String what, String from)
        {
            return $"{Select(what)} {From(from)}";
        }

        /// <summary>
        /// Builds a "from" clause.
        /// </summary>
        /// <param name="clause">The clause after the "from" keyword.</param>
        /// <returns>A "from" clause based on the given parameter.</returns>
        public static String From(String clause)
        {
            return $"from {clause}";
        }

        /// <summary>
        /// Builds a "group by" clause.
        /// </summary>
        /// <param name="criteria">The criteria to group by.</param>
        /// <returns>A "group by" clause based on the given criteria.</returns>
        public static String GroupBy(String criteria)
        {
            return $"group by {criteria}";
        }

        /// <summary>
        /// Builds an "order by" clause.
        /// </summary>
        /// <param name="criteria">The criteria to order by.</param>
        /// <returns>A "order by" clause based on the given criteria.</returns>
        public static String OrderBy(String criteria)
        {
            return $"order by {criteria}";
        }

        /// <summary>
        /// Builds a "having" clause.
        /// </summary>
        /// <param name="criteria">The criteria for the having clause.</param>
        /// <returns>A "having" clause based on the given criteria.</returns>
        public static String Having(String criteria)
        {
            return $"having {criteria}";
        }

        /// <summary>
        /// Builds an "as" clause.
        /// </summary>
        /// <param name="name">The given name to be aliased.</param>
        /// <param name="alias">The alias for the name.</param>
        /// <returns>An "alias" clause based on the given parameters.</returns>
        public static String As(String name, String alias)
        {
            return $"{name} as {alias}";
        }

        /// <summary>
        /// Builds a "where" clause.
        /// </summary>
        /// <param name="statement">The conditions to put in a where clause.</param>
        /// <returns>A "where" clause based on the given conditions.</returns>
        public static String Where(String conditions)
        {
            return $"where {conditions}";
        }

        /// <summary>
        /// Builds a "pivot" clause.
        /// </summary>
        /// <param name="what">The clause before the "pivot" keyword.</param>
        /// <param name="how">The clause after the "pivot" keyword.</param>
        /// <param name="as">The clause to use the "pivot" alias</param>
        /// <returns>A "pivot" clause based on the given parameters.</returns>
        public static String Pivot(String what, String how, String @as)
        {
            return As($"{what} pivot ({how})", @as); ;
        }

        /// <summary>
        /// Builds a "case" clause.
        /// </summary>
        /// <param name="what">The clause to put in a "case" clause.</param>
        /// <returns>A "case" clause based on the given parameter.</returns>
        public static String Case(String what)
        {
            return $"case {what} end";
        }

        /// <summary>
        /// Builds a "when" clause.
        /// </summary>
        /// <param name="condition">The condition clause.</param>
        /// <param name="result">The result clause.</param>
        /// <returns>A "when" clause based on the given parameters.</returns>
        public static String When(String condition, String result)
        {
            return $"when {condition} then {result}";
        }

        /// <summary>
        /// Builds an "else" clause.
        /// </summary>
        /// <param name="what">The clause to put after the "else" keyword.</param>
        /// <returns>An "else" clause based on the given parameters.</returns>
        public static String Else(String what)
        {
            return $"else {what}";
        }

        /// <summary>
        /// Builds an empty clause.
        /// </summary>
        /// <returns>Returns an empty clause.</returns>
        public static String Empty()
        {
            return String.Empty;
        }
    }
}
