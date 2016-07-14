using System;

using NUnit.Framework;

namespace RawQuery.Tests
{
    [TestFixture]
    public class FormatTests
    {
        private static Object[] MultilineCases = new Object[]
        {
            new Object[] { new[] { "1", "2" }, $"1{Environment.NewLine}2" }
        };
        

        [Test, TestCaseSource(nameof(MultilineCases))]
        public void Multiline_ShouldBeEqual(String[] strings, String expectation)
        {
            Assert.AreEqual(Format.Multiline(strings), expectation);
        }
    }
}
