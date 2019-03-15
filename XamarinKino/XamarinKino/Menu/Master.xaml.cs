using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinKino.Page;

namespace XamarinKino.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoImplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImplicitStylePage());
            IsPresented = false;
        }

        private void GoExplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ExplicitStylePage());
            IsPresented = false;
        }

        private void GoGlobalStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GlobalStylePage());
            IsPresented = false;
        }

        private void GoInheritanceStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new InheritanceStylePage());
            IsPresented = false;
        }

        private void GoDynamicStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DynamicStylePage());
            IsPresented = false;
        }
    }
}