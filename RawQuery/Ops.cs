using System;

namespace RawQuery
{
    /// <summary>
    /// Contains sql math operators.
    /// </summary>
    public static class Ops
    {
        /// <summary>
        /// Builds a "div" operator clause.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Returns a "div" clause based on the given parameters.</returns>
        public static String Div(String left, String right)
        {
            return $"{left} / {right}";
        }

        /// <summary>
        /// Builds a "mul" operator clause.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>Returns a "mul" clause based on the given parameters.</returns>
        public static String Mul(String left, String right)
        {
            return $"{left} * {right}";
        }
    }
}
