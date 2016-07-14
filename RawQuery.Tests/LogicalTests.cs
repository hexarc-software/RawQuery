using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace RawQuery.Tests
{
    [TestFixture]
    public class LogicalTests
    {
        [Test]
        public void IsNot_ShouldBeEqual()
        {
            Assert.AreEqual(Logical.IsNot("T", "V"), "T is not V");
        }
    }
}
