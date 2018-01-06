using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality.Tests
{
    [TestClass]
    class ValueTypeEqualityTests
    {
        [TestMethod]
        public void EqualityMethod()
        {
            TypeItem int1 = new TypeItem("int", ValueType.Int);
            Assert.Equals("int", int1.ToString());
        }
    }
}
