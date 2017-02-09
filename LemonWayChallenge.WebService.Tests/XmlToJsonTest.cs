using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWayChallenge.WebService.Tests
{
    [TestClass]
    public class XmlToJsonTest
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
        [DeploymentItem("XmlToJsonTestData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                           "|DataDirectory|\\XmlToJsonTestData.xml",
                           "Row",
                            DataAccessMethod.Random)]
        public void XmlToJsonWorks()
        {
            string xml = TestContext.DataRow["XML"].ToString();
            string expected = TestContext.DataRow["Result"].ToString();

            string actual = ServiceContext.XmlToJson(xml);

            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void Cleanup()
        {
            ServiceContext.Dispose();
        }
    }
}
