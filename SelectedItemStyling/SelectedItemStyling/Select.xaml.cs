using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SelectedItemStyling
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Select : ContentPage
	{
		public Select()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MainPage());
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new WithStyle());
		}

		private void Button_Clicked_2(object sender, EventArgs e)
		{
			Navigation.PushAsync(new CodeOnly());
		}

		private void Button_Clicked_3(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ConvenienceMethod());
		}
	}
}