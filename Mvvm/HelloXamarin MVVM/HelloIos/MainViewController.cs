using Foundation;
using GalaSoft.MvvmLight.Helpers;
using HelloIos;
using System;
using System.Collections.Generic;
using UIKit;

namespace Blank
{
    public partial class MainViewController : UIViewController
    {
        private List<Binding> _bindings = new List<Binding>();

        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _bindings.Add(
                this.SetBinding(
                    () => Application.Locator.Main.Result,
                    () => MyLabel.Text));

            MyButton.SetCommand(Application.Locator.Main.RefreshCommand);
        }
    }
}