using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPageTwo : ContentPage
	{
		public TabbedPageTwo ()
		{
			InitializeComponent ();
            btn.Clicked += Btn_Clicked; ;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage());
        }
    }
}