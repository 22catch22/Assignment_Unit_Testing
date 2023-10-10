 using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
   [TestClass()]
   public class Checkingtests
   {
   
   
[TestMethod()]
        public void WithdrawSomestuff()
        {
		 Checking Checktest = new Checking(420);
        double amount = 200
		double expectedResult = 220;
			 
			 Checktest.Withdraw(amount)
			 Assert.AreEqual(expectedResult,Checking.Withdraw())
        }
   [TestMethod()]
      public void WithdrawwithOver()
	  { 

		Checking Ctest = new Checking(420);
	   double amountToTakeout = 430;
	   double expected result = 405;
	  Checktest.Withdraw(amountToTakeout)
	   Assert.AreEqual (expected result,Ctest.Withdraw)
	  }
[TestMethod()]
	  public void DepositTest()
	  {	 Checking Dtest = new Checking(420);
	    double amounttoadd = 200;
		double newbalance = 620
		Assert.AreEqual(amounttoadd, newbalance);

	  }
[TestMethod()]
	public void NegaTest()

	{
		Checking Ctest = new Checking(420);
  		double amountadd = -15;
		double fail  = 405;

		Assert.AreNotEqual(fail, Ctest.Deposit);
	
	}

	  }
	  }