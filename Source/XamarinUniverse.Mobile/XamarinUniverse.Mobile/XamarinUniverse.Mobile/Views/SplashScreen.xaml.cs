using CommonServiceLocator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniverse.Mobile.ViewModels;
using XamarinUniverse.Mobile.Views.AppShell;

namespace XamarinUniverse.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        private readonly NewsViewModel _viewModel;

        public SplashScreen()
        {
            InitializeComponent();

            _viewModel = ServiceLocator.Current.GetInstance<NewsViewModel>();
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // try to autologin
            await ServiceLocator.Current.GetInstance<SettingsViewModel>().TryAutoLoginCommand.ExecuteAsync();

            await _viewModel.LoadPostsAsyncCommand.ExecuteAsync();
            Application.Current.MainPage = new AppShellPage();
        }
    }
}