using NUnit.Framework;
using CheckingandSavingtests;

namespace CheckingandSavingtests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1();
        
        public class Savingstest
        {
            [TestMethod()]
            public void Swithdrawtest()
            {

                Savings Sav = new Savings(800);
                double amountwith = 200;
                double newbalance = 600;

                Sav.Withdraw(amountwith);

                Assert.AreEqual(newbalance, Sav.Withdraw.balance);
            }
            [TestMethod()]
            public void snegatest()
            {
                Savings Save = new Savings(900);
                double mount = -15;
                double newbal = 900;

                Save.Withdraw(mount);

                Assert.AreEqual(newbal, Save.Withdraw);
                Assert.Fail();
            }
            [TestMethod()]
            public void Success()
            {
                Savings x = new Savings(700);
            double depo = 100;
                double ex = 800;

                x.Withdraw(depo);
            
Assert.AreEqual(ex, x.Withdraw);
            }

            [TextMethod()]
            public void NegativeTest()

            {
                Savings y = new Savings(600);
              double dep = -20;
                double news = 600;

                y.Withdraw(dep);
            
Assert.AreEqual(dep, y.Withdraw);




            }

        }
    }
}
    
