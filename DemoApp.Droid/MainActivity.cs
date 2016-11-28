using Android.App;
using Android.OS;
using Android.Widget;
using DemoApp.Core;

namespace DemoApp.Droid
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private HomeViewModel ViewModel => Locator.Instance.GetViewModel<HomeViewModel>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            FindViewById<TextView>(Resource.Id.textView).Text = ViewModel.EndpointText;
        }
    }
}