using System;
using System.Collections.Generic;
using System.Linq;

namespace RawQuery
{
    /// <summary>
    /// Contains logical sql clauses.
    /// </summary>
    public static class Logical
    {
        /// <summary>
        /// Builds an "is" clause.
        /// </summary>
        /// <param name="left">The argument before the "is" keyword.</param>
        /// <param name="right">The argument after the "is" keyword</param>
        /// <returns>An "is" clause based on the given parameters.</returns>
        public static String Is(String left, String right)
        {
            return $"{left} is {right}";
        }

        /// <summary>
        /// Builds an "is not" clause.
        /// </summary>
        /// <param name="left">The argument before the "is not" clause.</param>
        /// <param name="right">The argument after the "is not" clause.</param>
        /// <returns>An "is not" clause based on the given parameters.</returns>
        public static String IsNot(String left, String right)
        {
            return $"{Is(left, Not(right))}";
        }

        /// <summary>
        /// Builds a "not" clause.
        /// </summary>
        /// <param name="clause">The clause to negate.</param>
        /// <returns>A "not" clause based on the given parameter.</returns>
        public static String Not(String clause)
        {
            return $"not {clause}";
        }

        /// <summary>
        /// Builds an "equal" clause.
        /// </summary>
        /// <param name="left">The argument before the "equal" operator.</param>
        /// <param name="right">The argument after the "equal" operator.</param>
        /// <returns>An "equal" clause based on the given parameters.</returns>
        public static String Equal(String left, String right)
        {
            return $"{left} = {right}";
        }

        /// <summary>
        /// Builds a "not equal" clause.
        /// </summary>
        /// <param name="left">The argument before the "not equal" operator.</param>
        /// <param name="right">The argument after the "not equal" operator.</param>
        /// <returns>A "not equal" clause based on the given parameters.</returns>
        public static String NotEqual(String left, String right)
        {
            return $"{left} <> {right}";
        }

        /// <summary>
        /// Builds a "more" clause.
        /// </summary>
        /// <param name="left">The argument before the "more" operator.</param>
        /// <param name="right">The argument after the "more" operator.</param>
        /// <returns>A "more" clause based on the given parameters.</returns>
        public static String More(String left, String right)
        {
            return $"{left} > {right}";
        }

        /// <summary>
        /// Builds a "more equal" clause.
        /// </summary>
        /// <param name="left">The argument before the "more equal" operator.</param>
        /// <param name="right">The argument after the "more equal" operator.</param>
        /// <returns>A "more equal" clause based on the given parameters.</returns>
        public static String MoreEqual(String left, String right)
        {
            return $"{left} >= {right}";
        }

        /// <summary>
        /// Builds a "less" clause.
        /// </summary>
        /// <param name="left">The argument before the "less" operator.</param>
        /// <param name="right">The argument after the "less" operator.</param>
        /// <returns>A "less" clause based on the given parameters.</returns>
        public static String Less(String left, String right)
        {
            return $"{left} < {right}";
        }

        /// <summary>
        /// Builds a "less equal" clause.
        /// </summary>
        /// <param name="left">The argument before the "less equal" operator.</param>
        /// <param name="right">The argument after the "less equal" operator.</param>
        /// <returns>A "less equal" clause based on the given parameters.</returns>
        public static String LessEqual(String left, String right)
        {
            return $"{left} <= {right}";
        }

        /// <summary>
        /// Builds an "in" clause.
        /// </summary>
        /// <param name="list">The clause represented a list to put in.</param>
        /// <returns>An "in" clause based on the given parameter.</returns>
        public static String In(String list)
        {
            return $"in {Brackets.Round(list)}";
        }

        /// <summary>
        /// Builds an "in" clause.
        /// </summary>
        /// <param name="what">The clause before the "in" keyword.</param>
        /// <param name="list">The clause represented a list to put in brackets.</param>
        /// <returns>An "in" clause based on the given parameters.</returns>
        public static String In(String what, String list)
        {
            return $"{what} {In(list)}";
        }

        /// <summary>
        /// Builds a "for in" clause.
        /// </summary>
        /// <param name="what">The clause after the "for" and before the "in" keywords.</param>
        /// <param name="list">The clause represented a list to put in brackets.</param>
        /// <returns>A "for in" clause based on the given parameters.</returns>
        public static String ForIn(String what, String list)
        {
            return $"for {In(what, list)}";
        }

        /// <summary>
        /// Builds an "or" clause.
        /// </summary>
        /// <param name="left">The argument before the "or" keyword.</param>
        /// <param name="right">The argument after the "or" keyword.</param>
        /// <returns>An "or" clause based on the given parameters.</returns>
        public static String Or(String left, String right)
        {
            return $"{left} or {right}";
        }

        /// <summary>
        /// Builds an "or" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to be "or"ed.</param>
        /// <returns>An "or" clause based on the given collection.</returns>
        public static String Or(IEnumerable<String> clauses)
        {
            return String.Join(" or ", clauses.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds an "or" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to be "or"ed.</param>
        /// <returns>An "or" clause based on the given collection.</returns>
        public static String Or(params String[] clauses)
        {
            return Or(clauses.AsEnumerable());
        }

        /// <summary>
        /// Builds an "and" clause.
        /// </summary>
        /// <param name="left">The argument before the "and" keyword.</param>
        /// <param name="right">The argument after the "and" keyword.</param>
        /// <returns>An "and" clause based on the given parameters.</returns>
        public static String And(String left, String right)
        {
            return $"{left} and {right}";
        }

        /// <summary>
        /// Builds an "and" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to be "and"ed.</param>
        /// <returns>An "and" clause based on the given collection.</returns>
        public static String And(IEnumerable<String> clauses)
        {
            return String.Join(" and ", clauses.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds an "or" clause.
        /// </summary>
        /// <param name="clauses">The collection of clauses to be "and"ed.</param>
        /// <returns>An "and" clause based on the given collection.</returns>
        public static String And(params String[] clauses)
        {
            return And(clauses.AsEnumerable());
        }

        /// <summary>
        /// Builds a "between" clause.
        /// </summary>
        /// <param name="what">The clause to be checked for "between".</param>
        /// <param name="left">The left "between" value.</param>
        /// <param name="right">The right "between" value.</param>
        /// <returns>A "between" clause based on the given parameters.</returns>
        public static String Between(String what, String left, String right)
        {
            return $"{what} between {And(left, right)}";
        }
    }
}
