namespace Testscores;

public partial class MainPage : ContentPage
{
    int totalScore=0; //Accumulated Score
    int testScoreCount =0;
    float averageScore = 0;
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddScoreClicked(object sender, EventArgs e)
    {
        //Validate user input with tryparse
        if (int.TryParse(TxtScoreEntry.Text, out int testScore)&& testScore >=0 && testScore <=100)
        {
            ++testScoreCount;
        totalScore = totalScore + testScore;
            averageScore =(float)totalScore / testScoreCount;
            lblTotalScore.Text = $" {totalScore}";
            lblScoreCount.Text = $"{testScoreCount}";
            lblAverage.Text=$"{averageScore}";
        } 
    
        else
        {
            DisplayAlert("Invalid input", " Please enter a valid score", "ok");
            

        }
        TxtScoreEntry.Text=string.Empty;
    }
    private void OnClearClicked(object sender, EventArgs e)
    {
 lblTotalScore.Text= string.Empty;
        lblScoreCount.Text= string.Empty;
        lblAverage.Text= string.Empty;
        TxtScoreEntry.Text = string.Empty;
        totalScore=0;
        testScoreCount=0;
        averageScore=0;
    }
    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}


