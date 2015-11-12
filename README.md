DraggableListView
=================

Drag to rearrange ListView for Xamarin Android. This is Xamarin/C# port of the DevBytes Java Implementation (https://www.youtube.com/watch?v=_BZIvjMgH-Q)
with some modifications.

See MainActivity.cs for an implementation example. Note two things in the example:
Within the GetView method in the Adapter:
  The TranslationY property of the cell is reset
  The visibility of the cell is set based on the value of the mMobileCellPosition variable
  ...
    cell.Visibility = mMobileCellPosition == position ? ViewStates.Invisible : ViewStates.Visible;
		cell.TranslationY = 0;
	...


http://www.pranavkhandelwal.com/blog/2014/12/26/drag-rearrange-listview-for-xamarin-android

