using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics;

namespace DraggableListView
{
	[Activity (Label = "DraggableListView", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		List<string> items;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			var list = FindViewById<DraggableListView> (Resource.Id.listView1);


			items = new List<string> {
				"Vegetables",
				"Fruits",
				"Flower Buds",
				"Legumes",
				"Vegetables",
				"Fruits",
				"Flower Buds",
				"Legumes",
			};
			list.Adapter = new DraggableListAdapter (this, items);
		}
	}

	public class DraggableListAdapter : BaseAdapter, IDraggableListAdapter
	{
		public List<string> Items { get; set; }


		public int mMobileCellPosition { get; set; }

		Activity context;

		public DraggableListAdapter (Activity context, List<string> items) : base ()
		{
			Items = items;
			this.context = context;
			mMobileCellPosition = int.MinValue;
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return Items [position];
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View cell = convertView;
			if (cell == null) {
				cell = context.LayoutInflater.Inflate (Android.Resource.Layout.SimpleListItem1, parent, false);
				cell.SetMinimumHeight (150);
				cell.SetBackgroundColor (Color.DarkViolet);
			}

			var text = cell.FindViewById<TextView> (Android.Resource.Id.Text1);
			if (text != null) {
				text.Text = position.ToString ();
			}

			cell.Visibility = mMobileCellPosition == position ? ViewStates.Invisible : ViewStates.Visible;
			cell.TranslationY = 0;

			return cell;
		}

		public override int Count {
			get {
				return Items.Count;
			}
		}

		public void SwapItems (int indexOne, int indexTwo)
		{
			var oldValue = Items [indexOne];
			Items [indexOne] = Items [indexTwo];
			Items [indexTwo] = oldValue;
			mMobileCellPosition = indexTwo;
			NotifyDataSetChanged ();
		}
			
	}
}


