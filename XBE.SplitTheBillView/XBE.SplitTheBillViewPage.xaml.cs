﻿using System;
using Xamarin.Forms;
using XBE.SplitTheBill.Core;
using MvvmCross.Core.ViewModels;


namespace XBE.SplitTheBillView
{
	public partial class XBE_SplitTheBillViewPage : ContentPage
	{
		public XBE_SplitTheBillViewPage()
		{
			InitializeComponent();
		}

		//void OnTranslate(object sender, EventArgs e)
		//{
		//	translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
		//	if (!string.IsNullOrWhiteSpace(translatedNumber))
		//	{
		//		callButton.IsEnabled = true;
		//		callButton.Text = "Call " + translatedNumber;
		//	}
		//	else
		//	{
		//		callButton.IsEnabled = false;
		//		callButton.Text = "Call";
		//	}
		//}

		void OnCalculate(object sender, EventArgs e)
		{
			var bill = new BillCalculation();
			SplitBillViewModel model = new SplitBillViewModel(bill);
			model.totalBill =  amountText.Text != ""?Double.Parse(amountText.Text):0;
			model.numberofPeople = peopleText.Text != "" ? int.Parse(peopleText.Text) : 0;

			var toPay = model.Calculate();
			amountToPay.Text = toPay.ToString();
		
		}

		//async void OnCall(object sender, EventArgs e)
		//{
		//	if (await this.DisplayAlert(
		//			"Dial a Number",
		//			"Would you like to call " + translatedNumber + "?",
		//			"Yes",
		//			"No"))
		//	{
		//		var dialer = DependencyService.Get<IDialer>();
		//		if (dialer != null)
		//			dialer.Dial(translatedNumber);
		//	}
		//}
	}
}
