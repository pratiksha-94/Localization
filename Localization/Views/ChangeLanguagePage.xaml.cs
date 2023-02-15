using System.Globalization;
using System.Linq;
using System.Threading;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Localization.Resources;

namespace Localization.Views
{
    
    public partial class ChangeLanguagePage : ContentPage
    {
        public ChangeLanguagePage()
        {
            InitializeComponent();
        }

        void OnUpdateLanguageClicked(object sender,System.EventArgs e)
        {
            if(picker.SelectedItem!= null) 
            {
                var language = CultureInfo.GetCultures(CultureTypes.NeutralCultures).ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString()));
                Thread.CurrentThread.CurrentCulture = language;
                AppResources.Culture = language;
                App.Current.MainPage = new NavigationPage(new MainPage());
            }

        }
    }
}