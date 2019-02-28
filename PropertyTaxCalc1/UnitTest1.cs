using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PropertyTaxCalc1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test_Calculate_Taxable_Value()
		{
			PropertyTaxCalc home1 = new PropertyTaxCalc("123 New Street", 110000, 115000);
			Assert.AreEqual(90000, home1.CalculateTaxableValue());
		}

	

		[TestMethod]
		public void Test_Class_Output()
		{
			PropertyTaxCalc home1 = new PropertyTaxCalc("123 New Street", 110000, 115000);
			Console.WriteLine(home1);


			PropertyTaxCalc home2 = new PropertyTaxCalc("456 Long Street", 150000, 160000);
			Console.WriteLine(home2);


		}



	}
}
