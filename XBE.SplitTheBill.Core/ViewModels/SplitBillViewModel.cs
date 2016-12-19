using System;
using MvvmCross.Core.ViewModels;
namespace XBE.SplitTheBill.Core
{
	public class SplitBillViewModel:MvxViewModel
	{
		//TODO: Understand this
		readonly ISplitBillCalculation _billCalculation;
		public SplitBillViewModel(ISplitBillCalculation billCalculation)
		{
			_billCalculation = billCalculation;
		}

		public double totalBill { get; set; }
		public int numberofPeople { get; set; }

		public double Calculate()
		{
			var amount =   _billCalculation.AmountPerPerson(totalBill, numberofPeople);
			return amount;
		}


	}
}
