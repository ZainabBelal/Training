using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary1;

namespace TestAccounts
{
    [TestFixture]
    public class Testing1
    {
        Accounts acc;
        [Test]//marking this function as test
        public void TestMethod()
        {
            //arrange required objects
            Accounts acc = new Accounts("A1234");

            //ask
           // acc.Deposit();

            //assert
            //Assert.AreEqual(1001, acc.checkBalance());
        }
        [Test]
        public void checkLogin()
        {
            string l1 = acc.Login("Zainab", "1234");

        }
    }
}
