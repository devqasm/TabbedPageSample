using Xamarin.Forms;

namespace TabbedPageSample
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            var firstPage = new TabbedPageOne();
            var navigationFirstTab = new NavigationPage(firstPage);
            navigationFirstTab.Title = "First tab";

            var secondPage = new TabbedPageTwo();
            var navigationSecondTab = new NavigationPage(secondPage);
            navigationSecondTab.Title = "Second tab";

            // To avoid dubble navigation bar on android and iOS
            if (Device.RuntimePlatform != Device.UWP)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            this.Children.Add(navigationFirstTab);
            this.Children.Add(navigationSecondTab);
        }
    }
}
