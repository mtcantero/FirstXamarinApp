using System;
using System.ComponentModel;
using MvvmCross.Core.ViewModels;
namespace XBE.SplitTheBill.Core
{
	public class SplitBillViewModel : INotifyPropertyChanged
	{
		//TODO: Understand this
		readonly ISplitBillCalculation _billCalculation;

		public IMvxCommand CalculateCommand { get; private set; }

		#region Constructors

		public SplitBillViewModel(ISplitBillCalculation billCalculation)
		{
			_billCalculation = billCalculation;
		}

		public SplitBillViewModel()
		{
			_billCalculation = new BillCalculation();
			CalculateCommand = new MvxCommand(Calculate);

		}
		#endregion

		#region Properties
		double _totalBill;

		public double TotalBill
		{
			get
			{
				return _totalBill;

			}
			set
			{
				_totalBill = value;
				OnPropertyChanged("TotalBill");
				//Calculate();
			}

		}



		int _numberofPeople;
		public int NumberOfPeople
		{
			get
			{
				return _numberofPeople;
			}
			set
			{
				_numberofPeople = value;
				OnPropertyChanged("NumberOfPeople");
				//Calculate();
			}
		}

		double _amountPerPerson;



		public double AmountPerPerson
		{
			get
			{
				return _amountPerPerson;
			}
			private set
			{
				_amountPerPerson = value;
				OnPropertyChanged("AmountPerPerson");
			}
		}
		#endregion

		#region Methods

		void Calculate()
		{
			AmountPerPerson = _billCalculation.AmountPerPerson(TotalBill, NumberOfPeople);

		}


		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
		}

		#endregion



	}
}
