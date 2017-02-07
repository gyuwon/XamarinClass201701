using Android.App;
using Android.Widget;
using Android.OS;

namespace NativeCrossPlatform.Droid
{
	[Activity(Label = "NativeCrossPlatform", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private ClickCounterService _service;

		public MainActivity()
		{
			_service = new ClickCounterService();
		}

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += delegate
			{
				_service.OnClick();
				button.Text = _service.Message;
			};
		}
	}
}

