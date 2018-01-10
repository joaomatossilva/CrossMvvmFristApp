using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace CrossMvvmFristApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private string _text;
        private IMvxAsyncCommand _navigateCommand;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxCommand NavigateCommand =>
            _navigateCommand = _navigateCommand ?? new MvxAsyncCommand(DoNavigateCommand);

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public override void ViewCreated()
        {
            base.ViewCreated();
        }

        private async Task DoNavigateCommand()
        {
            await _navigationService.Navigate<DetailViewModel, int>(2);
        }
    }
}
