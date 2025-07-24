using Syncfusion.Maui.Buttons;

namespace SwitchGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSwitchStateChanged(object sender, SwitchStateChangedEventArgs e)
        {
            DisplayAlert("Message", "SUCCESS", "OK");
        }
    }

}
