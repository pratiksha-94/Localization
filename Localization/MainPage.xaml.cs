using System.ComponentModel;
using Localization.Resources;
using Localization.Views;
using Xamarin.Forms;

namespace Localization
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeLanguagePage());

        }
    }
}
