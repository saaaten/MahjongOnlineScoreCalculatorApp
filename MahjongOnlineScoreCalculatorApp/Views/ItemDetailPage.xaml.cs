using MahjongOnlineScoreCalculatorApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MahjongOnlineScoreCalculatorApp.Views
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