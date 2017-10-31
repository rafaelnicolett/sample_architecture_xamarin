using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Widget;
using MvvmCross.Droid.Platform;
using System.Reflection;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;
using MvvmCross.Localization;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using MvvmCross.Platform.Platform;
using SupportAndroid = Android.Support;

namespace Sample.Arch.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            //typeof(SupportAndroid.Design.Widget.CoordinatorLayout).Assembly,
            //typeof(SupportAndroid.Design.Widget.AppBarLayout).Assembly,
            //typeof(SupportAndroid.Design.Widget.CollapsingToolbarLayout).Assembly,
            //typeof(SupportAndroid.Design.Widget.NavigationView).Assembly,
            //typeof(SupportAndroid.Design.Widget.FloatingActionButton).Assembly,
            typeof(SupportAndroid.V7.Widget.Toolbar).Assembly,
            typeof(SupportAndroid.V4.Widget.DrawerLayout).Assembly,
            typeof(SupportAndroid.V4.View.ViewPager).Assembly,
            typeof(SupportAndroid.V7.RecyclerView.BuildConfig).Assembly,
            typeof(SupportAndroid.V4.Widget.NestedScrollView).Assembly,
            typeof(MvvmCross.Droid.Support.V7.RecyclerView.MvxRecyclerView).Assembly
        };

        /// <summary>
        /// This is very important to override. The default view presenter does not know how to show fragments!
        /// </summary>
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            base.InitializeFirstChance();

            //Mvx.RegisterSingleton<IDialogService>(new DialogService());

            var mvxFragmentsPresenter = new MvxAndroidViewPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

            //add a presentation hint handler to listen for pop to root
            mvxFragmentsPresenter.AddPresentationHintHandler<MvxPanelPopToRootPresentationHint>(hint =>
            {
                var activity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity;
                var fragmentActivity = activity as SupportAndroid.V4.App.FragmentActivity;

                for (int i = 0; i < fragmentActivity.SupportFragmentManager.BackStackEntryCount; i++)
                    fragmentActivity.SupportFragmentManager.PopBackStack();

                return true;
            });
            //register the presentation hint to pop to root
            //picked up in the third view model
            Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPanelPopToRootPresentationHint());
            return mvxFragmentsPresenter;
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
        }

        protected override IEnumerable<Assembly> ValueConverterAssemblies
        {
            get
            {
                var result = base.ValueConverterAssemblies.ToList();
                result.Add(typeof(MvxLanguageConverter).Assembly);
                return result;
            }
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }
    }
}