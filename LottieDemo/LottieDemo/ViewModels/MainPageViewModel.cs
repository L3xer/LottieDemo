using Prism.Navigation;

namespace LottieDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base (navigationService)
        {
            Title = "Lottie Demo";
        }
    }
}
