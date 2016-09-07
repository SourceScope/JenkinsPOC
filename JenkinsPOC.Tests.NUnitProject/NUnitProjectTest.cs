using JenkinsPOC.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsPOC.Tests.NUnitProject
{
    [TestFixture]
    public class NUnitProjectTest
    {
        [Test]
        public void TestExecute()
        {
            var doSomething = new DoSomething();
            var returnString = doSomething.Execute("asdf");

            Assert.AreEqual("asdf", returnString);
        }
    }
}
