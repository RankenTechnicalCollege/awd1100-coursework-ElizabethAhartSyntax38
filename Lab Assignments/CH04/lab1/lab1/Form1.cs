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
            string mile = Console.ReadLine();
            String Kilometer=Console.ReadLine();
          double userInput1= Convert.ToDouble(mile);
            double multiplied = userInput1, userinput2;
            double userInput2= Convert.ToDouble(Kilometer);
           
        }

        private void UserInput2_TextChanged(object sender, EventArgs e)
        {
            string kilometer = Console.ReadLine();
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            string lblDisplay = string.Format("{0} *{1}={2}");
}

        private void btnSubmit2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
