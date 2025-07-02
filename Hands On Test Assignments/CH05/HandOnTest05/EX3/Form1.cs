using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace EX3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
      private string  IsPresent(string Length, string Width)
        {

            string errorMessage = "";
            
           
            if (Length == "" && Width == "")
            {
                
                errorMessage = "is a required feild.";
                

            }
            return errorMessage;
           
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            IsPresent("","");

            int i = 50;
            int InputLength = Convert.ToInt32(txtBox1.Text);
            int InputWidth = Convert.ToInt32(txtBox2.Text);
            int Squarefeet = (InputLength * InputWidth);
            int Area = Squarefeet;

            if (Squarefeet > 600)
            {
                lblDisplayFEE.Text = $"50m";
            }
            else if (Squarefeet > 400)
            {
                lblDisplayFEE.Text = $"35m";
            }
            else if (Squarefeet < 400)
            {
                lblDisplayFEE.Text = "25m";
            }
            if (InputLength > 100)
            {
                lblDisplayWKS.Text = $"5";
            }
            else if (InputLength > 300)
            {
                lblDisplayWKS.Text = $"10";
            }
            if (Squarefeet <= 600)

            {
                lblDisplayWKS.Text = $"20";
            }

            if (Squarefeet <= 100)
            {
                lblDisplayArea.Text = $"{Squarefeet:c},FT";
            }
            else if (Squarefeet >= 101)
            {
                lblDisplayArea.Text = $"{Squarefeet}FT";

            }
            if (Squarefeet > 400 && Squarefeet < 600)
            {
                lblDisplayWKS.Text = "Minimum of 4 weeks at a time!";
                lblDisplayCost.Text = $"240";
            }
            else if (Squarefeet > 600 && Squarefeet != 0)
            {
                lblDisplayWKS.Text = $"Over size has a minimum of 4 weeks at a time!";
                lblDisplayCost.Text = $"100 handling fee Total 340";

            }
            else if (Squarefeet < 400)
            {
                lblDisplayWKS.Text = $"minimum of 3 weeks at a time!";
                lblDisplayCost.Text = $"180";

            }
            else if ((Squarefeet < 400))
            {
                lblDisplayWKS.Text = $"minimum of two weeks at a time";
                lblDisplayCost.Text = $"90";
            }
           
            
            




        }
    }



























}
    


        
    

