using System;
namespace XBE.SplitTheBill.Core
{
	public class BillCalculation : ISplitBillCalculation
	{
		public BillCalculation()
		{
		}
		#region ISplitBillCalculation implementation

		public double AmountPerPerson(double totalBill, int numberOfPeople, int percentageOfTip)
		{
			return ((totalBill) * ((double)percentageOfTip / 100) / numberOfPeople);
		}

		#endregion
	}
}
