using System;
using System.Collections.Generic;
using System.Linq;

namespace RawQuery
{
    /// <summary>
    /// Contains aux formatting methods.
    /// </summary>
    public static class Format
    {
        /// <summary>
        /// Builds an sql list separated by commas.
        /// </summary>
        /// <param name="collection">The collection of strings to build a list of.</param>
        /// <returns>An sql list of the given collection.</returns>
        public static String List(IEnumerable<String> collection)
        {
            return String.Join(", ", collection.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds an sql list separated by commas.
        /// </summary>
        /// <param name="collection">The collection of strings to build a list of.</param>
        /// <returns>An sql list of the given collection.</returns>
        public static String List(params String[] collection)
        {
            return List(collection.AsEnumerable());
        }

        /// <summary>
        /// Builds a multiline string.
        /// </summary>
        /// <param name="collection">The collection of strings to build a multiline string of.</param>
        /// <returns>An multiline string based on the given collection.</returns>
        public static String Multiline(IEnumerable<String> collection)
        {
            return String.Join(Environment.NewLine, collection.Where(x => !String.IsNullOrEmpty(x)));
        }

        /// <summary>
        /// Builds a multiline string.
        /// </summary>
        /// <param name="collection">The collection of strings to build a multiline string of.</param>
        /// <returns>An multiline string based on the given collection.</returns>
        public static String Multiline(params String[] collection)
        {
            return Multiline(collection.AsEnumerable());
        }
    }
}
