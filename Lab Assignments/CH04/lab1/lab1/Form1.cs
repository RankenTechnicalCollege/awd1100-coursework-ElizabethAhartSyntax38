using System.Reflection.Metadata;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userInput1_TextChanged(object sender, EventArgs e)
        {


        }

        private void UserInput2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            
            Decimal userInputMiles = Convert.ToDecimal(userInput1.Text);
            labelDisplay.Text = (userInputMiles * 1.6m).ToString();
            

        }
        
        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            
            Decimal UserInputKilometers = Convert.ToDecimal(UserInput2.Text);
            labelDisplay.Text = (UserInputKilometers / 1.6m).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userInput1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
