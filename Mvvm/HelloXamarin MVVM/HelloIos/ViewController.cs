using GalaSoft.MvvmLight.Helpers;
using System;
using System.Collections.Generic;
using UIKit;

namespace HelloIos
{
    public partial class ViewController : UIViewController
    {
        private List<Binding> _bindings = new List<Binding>();

        public ViewController(IntPtr handle) : base(handle)
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