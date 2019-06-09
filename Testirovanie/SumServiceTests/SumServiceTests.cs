using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testirovanie;
using NUnit.Framework;

namespace Testirovanie
{
    [TestFixture]
    public class SumServiceюTests
    {
        [Test]
        // arrange (организация)
        public void Sum_One_And_One()
        {
            var sumService = new SumService();
            // act (акт)
            var result = sumService.Sum(1, 1);
            // assert (утверждение)
            Assert.AreEqual(2, result);
        }
    }
}
