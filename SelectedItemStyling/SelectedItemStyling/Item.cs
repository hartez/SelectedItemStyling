namespace SelectedItemStyling
{
	public class Item
	{ 
		public string Title { get; set; }
		public string Description { get; set; }

		public Item(string title, string description)
		{
			Title = title;
			Description = description;
		}
	}
}
