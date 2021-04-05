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

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Employee employee = ((AddOrEditAdvancedEmployeeViewModel)BindingContext).Employee;

            MessagingCenter.Send(this, "AddOrEditAdvancedEmployee", employee);

            await Navigation.PushAsync(new GamePage());
        }
    }
}