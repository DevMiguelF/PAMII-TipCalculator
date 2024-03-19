namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button15Percent_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void PercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentageLabel.Text = $"{PercentageSlider.Value.toString()}%";
        }
    }

}
