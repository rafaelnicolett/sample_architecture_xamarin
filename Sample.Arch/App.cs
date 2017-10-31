using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using Sample.Arch.ViewModels;

namespace Sample.Arch
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .InNamespace("Sample.Arch.Services")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            RegisterNavigationServiceAppStart<StartViewModel>();
        }
    }
}
