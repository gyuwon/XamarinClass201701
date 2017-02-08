// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BatteryChecker.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BatteryStatusLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton UpdateButton { get; set; }

        [Action ("OnUpdateButtonUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnUpdateButtonUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BatteryStatusLabel != null) {
                BatteryStatusLabel.Dispose ();
                BatteryStatusLabel = null;
            }

            if (UpdateButton != null) {
                UpdateButton.Dispose ();
                UpdateButton = null;
            }
        }
    }
}