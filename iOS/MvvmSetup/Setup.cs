using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using UIKit;
using MvvmCross.Platform;
using Sample.Arch.Services;
using Sample.Arch.iOS.Services;

namespace Sample.Arch.iOS.MvvmSetup
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            return base.CreatePresenter();
        }

        protected override void InitializeFirstChance()
        {
            Mvx.RegisterSingleton<ISampleNativeService>(new SampleNativeService());

            base.InitializeFirstChance();

        }
    }
}
