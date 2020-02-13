using System.Collections.Generic;

namespace SelectedItemStyling
{
	public class ViewModel 
	{ 
		public List<Item> Items { get; set; }

		public ViewModel() 
		{
			Items = new List<Item>() 
			{ 
				new Item("Title 1", "This is the description for 1"),
				new Item("Title 2", "This is the description for 2"),
				new Item("Title 3", "This is the description for 3"),
				new Item("Title 4", "This is the description for 4"),
			};
		}
	}
}
