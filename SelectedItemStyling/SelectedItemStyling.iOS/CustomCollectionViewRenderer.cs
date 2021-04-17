using Foundation;
using SelectedItemStyling.iOS;
using System.Diagnostics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CollectionView), typeof(CustomCollectionViewRenderer))]
namespace SelectedItemStyling.iOS
{
	public class CustomCollectionViewRenderer : CollectionViewRenderer 
    {
		protected override GroupableItemsViewController<GroupableItemsView> CreateController(GroupableItemsView itemsView, ItemsViewLayout layout)
		{
			return new CustomItemsViewController(itemsView, layout);
		}
	}

	public class CustomItemsViewController : GroupableItemsViewController<GroupableItemsView>
	{
		public CustomItemsViewController(GroupableItemsView groupableItemsView, ItemsViewLayout layout) : base(groupableItemsView, layout)
		{
		}

		protected override UICollectionViewDelegateFlowLayout CreateDelegator()
		{
			return new CustomDelegator(ItemsViewLayout, this);
		}
	}

	public class CustomDelegator : ItemsViewDelegator<GroupableItemsView, GroupableItemsViewController<GroupableItemsView>>
	{
		public CustomDelegator(ItemsViewLayout itemsViewLayout, GroupableItemsViewController<GroupableItemsView> itemsViewController) : base(itemsViewLayout, itemsViewController)
		{
		}

		public override void ItemHighlighted(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem(indexPath);
			cell.SelectedBackgroundView = null;
			cell.BackgroundColor = UIColor.Orange;
		}

		public override void ItemUnhighlighted(UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.CellForItem(indexPath);
			cell.BackgroundColor = null;
		}
	}
}
