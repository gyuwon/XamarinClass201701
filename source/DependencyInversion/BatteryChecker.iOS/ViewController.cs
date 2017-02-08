using System;

using UIKit;

namespace BatteryChecker.iOS
{
	public partial class ViewController : UIViewController, IBatteryService
	{
		private BatteryDisplayBiz _biz;

		public ViewController (IntPtr handle) : base (handle)
		{
			_biz = new BatteryDisplayBiz(this);
		}

		partial void OnUpdateButtonUpInside(UIButton sender)
		{
			BatteryStatusLabel.Text = _biz.Message;
		}

		public int GetBatteryPercent()
		{
			return (int)(UIDevice.CurrentDevice.BatteryLevel * 100F);
		}
	}
}

