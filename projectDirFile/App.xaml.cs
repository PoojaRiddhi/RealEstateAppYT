using MauiFirstApp.View;
using MauiFirstApp.ViewModel;

namespace MauiFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(root: new LandingPage());
        }
    }
}
