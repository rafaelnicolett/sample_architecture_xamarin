
using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Sample.Arch.Droid
{
    [Activity(Label = "Sample", MainLauncher = true,
              NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }
    }
}