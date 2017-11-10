
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Sample.Arch.ViewModels;

namespace Sample.Arch.Droid
{
    [Activity(Label = "SecondView")]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.second_view);
        }
    }
}