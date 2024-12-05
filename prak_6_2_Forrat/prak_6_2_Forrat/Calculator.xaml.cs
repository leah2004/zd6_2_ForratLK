using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prak_6_2_Forrat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator : ContentPage
    {
        public string username;
        public Calculator()
        {
            InitializeComponent();
           
        }
       
        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;


            if (!string.IsNullOrWhiteSpace(username)&& !string.IsNullOrWhiteSpace(password) && username == "ects" && password == "ects2024")
            {               
                await Navigation.PushModalAsync(new Calculator4());
               
            }
            else
            {
                await DisplayAlert("ERROR", "Введите данные корректно", "ок");
            }
        }
    }
}