using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SelectedItemStyling
{
	public class CodeOnly : ContentPage
	{
		public CodeOnly() 
		{
			var layout = new StackLayout();

			var label = new Label { Text = "This layout is done entirely in code, even the VisualState stuff for selection appearance." };

			var cv = new CollectionView();

			cv.SetBinding(CollectionView.ItemsSourceProperty, new Binding("Items"));
			cv.SelectionMode = SelectionMode.Single;

			cv.ItemTemplate = new DataTemplate(() =>
			{
				var grid = new Grid
				{
					RowDefinitions = new RowDefinitionCollection { new RowDefinition(), new RowDefinition() }
				};

				var title = new Label { FontSize = 25 };
				title.SetBinding(Label.TextProperty, new Binding("Title"));

				var description = new Label { FontSize = 12 };
				description.SetBinding(Label.TextProperty, new Binding("Description"));
				Grid.SetRow(description, 1);

				grid.Children.Add(title);
				grid.Children.Add(description);

				var backColorSetter = new Setter { Value = Color.Lavender, Property = BackgroundColorProperty };

				var stateGroup = new VisualStateGroup { Name = "Common", TargetType = typeof(Grid) };

				var normalState = new VisualState
				{
					Name = "Normal",
					TargetType = typeof(Grid),
					Setters = { }
				};

				var selectedState = new VisualState
				{
					Name = "Selected",
					TargetType = typeof(Grid),
					Setters = { backColorSetter }
				};

				stateGroup.States.Add(normalState);
				stateGroup.States.Add(selectedState);

				VisualStateManager.SetVisualStateGroups(grid, new VisualStateGroupList { stateGroup });

				return grid;
			});

			layout.Children.Add(label);
			layout.Children.Add(cv);

			Content = layout;

			BindingContext = new ViewModel();
		}
	}
}
