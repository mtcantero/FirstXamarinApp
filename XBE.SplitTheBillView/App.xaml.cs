using System.Diagnostics;
using Xamarin.Forms;

namespace XBE.SplitTheBillView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new XBE_SplitTheBillViewPage();
			MainPage = new ContentPage
			{
				Title = "Sample"
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			Debug.WriteLine("OnStart Triggered");
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			Debug.WriteLine("OnSleep Triggered");
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
			Debug.WriteLine("OnResume Triggered");
		}
	}
}
