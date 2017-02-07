using System;

using UIKit;

namespace NativeCrossPlatform.iOS
{
	public partial class ViewController : UIViewController
	{
		private ClickCounterService _service;

		public ViewController(IntPtr handle) : base(handle)
		{
			_service = new ClickCounterService();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				_service.OnClick();
				Button.SetTitle(_service.Message, UIControlState.Normal);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
