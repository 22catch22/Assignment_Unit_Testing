using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingandSavingtests
{
    public void Test1();

    public class CheckingTest
    {
        [TestMethod()]
        public void SChecktest()
        {

            Checking chek = new Checking(800);
            double amountwith = 200;
            double newbalance = 600;

            chek.Withdraw(amountwith);

            Assert.AreEqual(newbalance, chek.Withdraw.balance);
        }
        [TestMethod()]
        public void snegatest()
        {
            Checking CK = new Checking(900);
            double mount = -15;
            double newbal = 900;

           CK.Withdraw(mount);

            Assert.AreEqual(newbal, CK.Withdraw);
            Assert.Fail();
        }
        [TestMethod()]
        public void Success()
        {
            Checking x = new Checking(700);
            double depo = 100;
            double ex = 800;

            x.Withdraw(depo);

            Assert.AreEqual(ex, x.Withdraw);
        }

        [TextMethod()]
        public void NegativeTest()

        {
            Checking y = new Checking(600);
            double dep = -20;
            double news = 600;

            y.Withdraw(dep);

            Assert.AreEqual(dep, y.Withdraw);




        }

    }
}


