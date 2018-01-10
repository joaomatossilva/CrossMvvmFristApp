using MvvmCross.Platform.IoC;
using MvvmCross.Core.ViewModels;

namespace CrossMvvmFristApp.Core.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //RegisterAppStart<ViewModels.MainViewModel>();
            RegisterNavigationServiceAppStart<ViewModels.MainViewModel>();
        }
    }
}
