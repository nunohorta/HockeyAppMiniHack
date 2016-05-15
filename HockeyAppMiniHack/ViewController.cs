using System;

using UIKit;

namespace HockeyAppMiniHack
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		object nullObject = null;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CrashButton.TouchUpInside += (object sender, EventArgs e) => {
				nullObject.ToString();
			};
		}
	}
}

