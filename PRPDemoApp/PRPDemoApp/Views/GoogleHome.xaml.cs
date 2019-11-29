using Xamarin.Forms;

namespace PRPDemoApp.Views
{
    public partial class GoogleHome : ContentPage
    {
        public GoogleHome()
        {
            InitializeComponent();
            GoogleWebview.Source = "https://www.google.com/";
        }
    }
}