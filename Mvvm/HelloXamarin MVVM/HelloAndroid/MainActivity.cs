using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button _button;
        private TextView _text;
        private List<Binding> _bindings = new List<Binding>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            _button = FindViewById<Button>(Resource.Id.MyButton);
            _text = FindViewById<TextView>(Resource.Id.MyText);

            _bindings.Add(
                this.SetBinding(
                    () => App.Locator.Main.Result,
                    () => _text.Text));

            _button.SetCommand(App.Locator.Main.RefreshCommand);
        }
    }
}

