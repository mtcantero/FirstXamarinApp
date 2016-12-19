using System;
namespace XBE.SplitTheBill.Core
{
	public class BillCalculation : ISplitBillCalculation
	{
		public BillCalculation()
		{
		}
		#region ISplitBillCalculation implementation

		public double AmountPerPerson(double totalBill, int numberOfPeople)
		{
			return (totalBill / numberOfPeople);
		}

		#endregion
	}
}
