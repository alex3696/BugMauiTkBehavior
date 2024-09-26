This project aims to demonstrate a bug of `TouchBehavior` in CommunityToolkit.Maui. The `CollectionView` has `SelectionMode` set to `Multiple`. 
After setting `TouchBehavior` to Grid inside `CollectionView`'s `ItemTemplate`, the `SelectedItems` is always empty.
Every time you click on one item, the count of `SelectedItems` increases but becomes empty immediately.