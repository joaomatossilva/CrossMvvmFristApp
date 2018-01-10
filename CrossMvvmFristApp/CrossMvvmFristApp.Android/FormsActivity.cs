using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid.Views;
using MvvmCross.Platform;

namespace CrossMvvmFristApp.Droid
{
    [Activity(Label = "CrossMvvmFristApp.Droid", Icon = "@drawable/icon", Theme = "@style/MainTheme",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class FormsActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //ActionBar.
            base.OnCreate(bundle);
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;
        }
    }
}
