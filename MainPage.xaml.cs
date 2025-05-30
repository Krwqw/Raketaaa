using Microsoft.Maui.Controls.Shapes;

namespace raketa1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnFire(object sender, EventArgs e)
        {
            Fire1.IsVisible = true;
            Fire2.IsVisible = true;
            Fire3.IsVisible = true;
            Window1.Fill = Colors.Aqua;
            Window2.Fill = Colors.Aqua;
        }


        private async void OffFire(object sender, EventArgs e)
        {

            Fire1.IsVisible = false;
            Fire2.IsVisible = false;
            Fire3.IsVisible = false;
            Window1.Fill = Colors.Black;
            Window2.Fill = Colors.Black;
        }
    }
}

