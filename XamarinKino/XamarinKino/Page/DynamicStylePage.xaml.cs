using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinKino.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void ChangeColorEvent(object sender, EventArgs e)
        {
            Resources["LblColor"] = Color.Orange;
            Resources["Lbl"] = Resources["NewLbl"];
        }
    }
}