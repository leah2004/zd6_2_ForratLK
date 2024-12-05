using prak_6_2_Forrat.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace prak_6_2_Forrat.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}