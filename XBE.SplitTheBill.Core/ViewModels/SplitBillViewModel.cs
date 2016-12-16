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

		public void Calculate()
		{
			AmountPerPerson = _billCalculation.AmountPerPerson(TotalBill, NumberOfPeople, PercentageOfTip);
		}

		double _totalBill;
		public double TotalBill
		{
			get { return _totalBill; }
			set
			{
				_totalBill = value;
				RaisePropertyChanged(() => TotalBill);
				Calculate();
			}
		}


		int _numberOfPeople;
		public int NumberOfPeople
		{
			get { return _numberOfPeople; }
			set
			{
				_numberOfPeople = value;
				RaisePropertyChanged(() => NumberOfPeople);
				Calculate();
			}
		}

		int _percentageOfTip;
		public int PercentageOfTip
		{
			get { return _percentageOfTip; }
			set
			{
				_percentageOfTip = value;
				RaisePropertyChanged(() => PercentageOfTip);
				Calculate();
			}
		}

		double _amountPerPerson;
		public double AmountPerPerson
		{
			get { return _amountPerPerson; }
			private set
			{
				_amountPerPerson = value;
				RaisePropertyChanged(() => AmountPerPerson);
			}
		}
	}
}
