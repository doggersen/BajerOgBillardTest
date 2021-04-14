using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BajerOgBillardTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPlayerPage : ContentPage
    {
        public AddPlayerPage()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            //making a variable called "employee" of type "Employee", and assigning it ....to what exactly?
             Player player = ((AddPlayerViewModel)BindingContext).Player;
     
            MessagingCenter.Send(this, "AddPlayer", player);

            Navigation.PopAsync();

           
        }
    }
}