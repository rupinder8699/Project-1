using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    [TestFixture]
    class UnitTest
    {
        [TestCase]
        public void spincount()
        {
            Form4 spinobj = new Form4();
            Assert.AreEqual(1, spinobj.spin_fuc(6));
        }

        [TestCase]
        public void spincount_neg()
        {
            Form4 spinobj_neg = new Form4();
            Assert.AreNotEqual(2, spinobj_neg.spin_fuc(6));
        }
    }
}
