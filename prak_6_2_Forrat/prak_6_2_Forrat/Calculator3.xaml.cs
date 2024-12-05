using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prak_6_2_Forrat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator3 : ContentPage
    {
        public Calculator3()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            DateTime currentDate = DateTime.Now;
            CurrentDateLabel.Text = currentDate.ToString("dd MMMM yyyy");
        }
    }
}