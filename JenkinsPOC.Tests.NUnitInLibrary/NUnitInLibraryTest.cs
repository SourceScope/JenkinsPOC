using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JenkinsPOC.Library;

namespace JenkinsPOC.Tests.NUnitInLibrary
{
    public class NUnitInLibraryTest
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
