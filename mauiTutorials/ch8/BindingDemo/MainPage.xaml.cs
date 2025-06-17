using System.Collections.ObjectModel;

namespace BindingDemo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<int> TestScores { get; set; } = new ObservableCollection<int>() { 85, 92, 76, 88, 95 };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this; //Set he binding context to the mainpaige instance to enable
        }

        private void btnAddScore_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtAddScore.Text, out int newScore) && newScore >= 0 && newScore <= 100)
            {
                TestScores.Add(newScore);
                txtAddScore.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid Score between 0-100.", "ok");
            }
        }
        
        private void OnDeleteScore_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is int score)
            {
                TestScores.Remove(score);
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid Score between 0-100.", "ok");
            }
        }

        private void btnAddScore_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}

