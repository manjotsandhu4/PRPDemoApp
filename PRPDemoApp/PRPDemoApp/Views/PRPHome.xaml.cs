using Xamarin.Forms;

namespace PRPDemoApp.Views
{
    public partial class PRPHome : ContentPage
    {
        public PRPHome()
        {
            InitializeComponent();
            //Providing url for webview
            PrpWebview.Source = "https://www.peelpolice.ca/en/index.aspx";
        }
    }
}