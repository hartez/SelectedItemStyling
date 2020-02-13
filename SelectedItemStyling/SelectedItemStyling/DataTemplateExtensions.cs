using Xamarin.Forms;

namespace SelectedItemStyling
{
	public static class DataTemplateExtensions
	{
		// This extension method will generate the VisualStateGroups necessary to set a simple background color for 
		// the Selected state on your DataTemplate.

		// See ConvenienceMethod.xaml.cs for a usage example

		public static DataTemplate WithSelectedBackgroundColor(this DataTemplate template, Color backgroundColor) 
		{
			return new DataTemplate(() => {
				var content = template.CreateContent() as VisualElement;

				var backColorSetter = new Setter { Value = backgroundColor, Property = VisualElement.BackgroundColorProperty };

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

				VisualStateManager.SetVisualStateGroups(content, new VisualStateGroupList { stateGroup });

				return content;
			});
		}
	}
}
