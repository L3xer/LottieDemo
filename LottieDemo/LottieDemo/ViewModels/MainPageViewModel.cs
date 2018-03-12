using Prism.Navigation;
using Plugin.Connectivity;

namespace LottieDemo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public enum ViewState
        {
            NoInternet,
            Connected
        }

        public ViewState _state;
        public ViewState State
        {
            get { return _state; }
            private set { SetProperty(ref _state, value); }
        }


        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Lottie Demo";

            State = GetCurrentViewState();

            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
        }

        private void Current_ConnectivityChanged(object sender, Plugin.Connectivity.Abstractions.ConnectivityChangedEventArgs e)
        {
            State = GetCurrentViewState();
        }

        private ViewState GetCurrentViewState()
        {
            return CrossConnectivity.Current.IsConnected ? ViewState.Connected : ViewState.NoInternet;
        }
    }
}


