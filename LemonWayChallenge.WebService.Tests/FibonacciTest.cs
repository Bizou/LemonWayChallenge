using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LemonWayChallenge.WebService.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        private Service m_service;
        private TestContext m_testContext;

        public Service ServiceContext
        {
            get { return m_service; }
            set { m_service = value; }
        }

        public TestContext TestContext
        {
            get { return m_testContext; }
            set { m_testContext = value; }
        }

        [TestInitialize]
        public void Initialize()
        {
            ServiceContext = new Service();
        }

        [TestMethod]
        [DeploymentItem("FibonacciTestData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                           "|DataDirectory|\\FibonacciTestData.xml",
                           "Row",
                            DataAccessMethod.Random)]
        public void FibonacciWorks()
        {
            int n = Convert.ToInt32(TestContext.DataRow["N"]);
            int expected = Convert.ToInt32(TestContext.DataRow["Result"]);

            int actual = ServiceContext.Fibonacci(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void Cleanup()
        {
            ServiceContext.Dispose();
        }
    }
}
