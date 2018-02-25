using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using System.Collections.Generic;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Binding> _bindings = new List<Binding>();
        private Button _button;
        private TextView _text;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _button = FindViewById<Button>(Resource.Id.MyButton);
            _text = FindViewById<TextView>(Resource.Id.MyTextView);

            _bindings.Add(
                this.SetBinding(
                    () => App.Locator.Main.Result,
                    () => _text.Text));

            _button.SetCommand(App.Locator.Main.RefreshCommand);
        }
    }
}

