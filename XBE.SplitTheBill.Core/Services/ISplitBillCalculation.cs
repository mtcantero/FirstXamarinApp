using System;
namespace XBE.SplitTheBill.Core
{
	public interface ISplitBillCalculation
	{
		double AmountPerPerson(double totalBill, int numberOfPeople, int percentageOfTip);
	}
}
