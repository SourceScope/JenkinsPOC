using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsPOC.Library;

namespace JenkinsPOC.Tests.Microsoft
{
    [TestClass]
    public class MicrosoftUnitTest
    {
        [TestMethod]
        public void TestExecute()
        {
            var doSomething = new DoSomething();
            var returnString = doSomething.Execute("asdf");

            Assert.AreEqual("asdf", returnString);
        }
    }
}
