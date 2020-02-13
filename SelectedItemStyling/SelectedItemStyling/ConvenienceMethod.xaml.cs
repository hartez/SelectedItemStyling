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
	public partial class ConvenienceMethod : ContentPage
	{
		public ConvenienceMethod()
		{
			InitializeComponent();

			MyCollectionView.ItemTemplate = MyCollectionView.ItemTemplate.WithSelectedBackgroundColor(Color.Goldenrod);

			BindingContext = new ViewModel();
		}
	}
}