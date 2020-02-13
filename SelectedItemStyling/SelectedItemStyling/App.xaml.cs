using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelectedItemStyling
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Select());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
