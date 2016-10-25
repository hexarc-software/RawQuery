using System;

namespace RawQuery
{
    /// <summary>
    /// Contains converters to sql literals.
    /// </summary>
    public static class To
    {
        /// <summary>
        /// Converts a given string to an sql string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql string.</returns>
        public static String String(String value)
        {
            return value == null ? "null" : $"'{value.Replace("'", "''")}'";
        }

        /// <summary>
        /// Converts a given Int32 instance to an sql number.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql number.</returns>
        public static String Number(Int32 value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Converts a given Int32? instance to an sql number.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql number.</returns>
        public static String Number(Int32? value)
        {
            return value == null ? "null" : Number(value.Value);
        }

        /// <summary>
        /// Converts a given Double instance to an sql number.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql number.</returns>
        public static String Number(Double value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Converts a given Double? instance to an sql number.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql number.</returns>
        public static String Number(Double? value)
        {
            return value == null ? "null" : Number(value.Value);
        }

        /// <summary>
        /// Converts a given DateTime instance to an sql datetime literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql datetime literal.</returns>
        public static String DateTime(DateTime value)
        {
            return $"'{value.ToString("yyyy-MM-dd HH:mm:ss")}'";
        }

        /// <summary>
        /// Converts a given DateTime? instance to an sql datetime literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql datetime literal.</returns>
        public static String DateTime(DateTime? value)
        {
            return value == null ? "null" : DateTime(value.Value);
        }

        /// <summary>
        /// Converts a given DateTime instance to an sql date literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql date literal.</returns>
        public static String Date(DateTime value)
        {
            return $"'{value.ToString("yyyy-MM-dd")}'";
        }

        /// <summary>
        /// Converts a given DateTime? instance to an sql date literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql date literal.</returns>
        public static String Date(DateTime? value)
        {
            return value == null ? "null" : Date(value.Value);
        }

        /// <summary>
        /// Converts a Guid instane to an sql uniqueidentifier literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql uniqueidentifier literal.</returns>
        public static String Guid(Guid value)
        {
            return $"'{value.ToString()}'";
        }

        /// <summary>
        /// Converts a Guid? instane to an sql uniqueidentifier literal.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>An sql uniqueidentifier literal.</returns>
        public static String Guid(Guid? value)
        {
            return value == null ? "null" : Guid(value.Value);
        }
    }
}
