using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger.NHibernateSetup;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using logImplementer;

namespace NhibernateTest
{
    [TestClass]
    public class UnitTest1
    {
        ISession Session = null;
        NhibernateSetup config = null;
        [TestInitialize]
        public void InitSetup()
        {
            config = new NhibernateSetup();
        }

        [TestMethod]
        public void CreateDb()
        {
            config.Setup();
            Session = config.sessionFactory.OpenSession();
            new SchemaExport(config.cfg).Execute(true, true, false);
            // .Execute(true, true, false, false);
        }
        [TestMethod]
        public void TestMethod1()
        {
            CRM obj = new CRM();
            Emailr mailr = new Emailr();
            OSR osr = new OSR();
            //Abhijeet

            obj.WriteLogForCRM();
            osr.WriteLogForOSR();
            mailr.WriteLogForEmailr();
        }
        [TestMethod]
        public void ss()
        {
            string EnteredNum = "asp";
            string UserType = "213";

            string UniqueID = "123";
            var Result = EnteredNum + "#" + UserType + "#" + UniqueID;
            Assert.AreEqual("asp#213#1233", Result);
        }
    }
}
