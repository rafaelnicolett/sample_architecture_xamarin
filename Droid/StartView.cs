
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Sample.Arch.ViewModels;

namespace Sample.Arch.Droid
{
    [Activity(Label = "StartView")]
    public class StartView : MvxActivity<StartViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.start_view);
        }
    }
}