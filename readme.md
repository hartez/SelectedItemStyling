# SelectedItem styling examples for Xamarin.Forms CollectionView

This repo shows a few different ways you can style the currently selected item(s) in a CollectionView. 

"Selected" is a VisualState which is set on the root element of any currently selected items. This allows for the appearance of the item and all of its content to be changed when the item is selected. 

Here is a change

This repo contains examples of four different ways to set the appearance of selected items:

- Directly on the ItemTemplate in XAML
- With a Style which can be re-used on ItemTemplates throughout the application
- In code, in your DataTemplate constructor
- Using an extension method to set the selected background color

The code in this repo requires Xamarin.Forms version 4.5.0.282-pre4 or higher. 

None of this currently works on UWP - this is a known bug and we're working on it. 
