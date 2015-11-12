Drag and Drop ListView
=================

Drag to rearrange ListView for Xamarin Android. This is Xamarin/C# port of the DevBytes Java Implementation (https://www.youtube.com/watch?v=_BZIvjMgH-Q)
with some modifications.

See MainActivity.cs for an implementation example. Note two things in the example:
Within the GetView method in the Adapter:

      1. The TranslationY property of the cell is reset
  
      2. The visibility of the cell is set based on the value of the mMobileCellPosition variable

http://www.pranavkhandelwal.com/blog/2014/12/26/drag-rearrange-listview-for-xamarin-android

