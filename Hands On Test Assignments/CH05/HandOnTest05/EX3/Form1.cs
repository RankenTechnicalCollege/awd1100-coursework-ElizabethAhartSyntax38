using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace EX3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
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
            if (Squarefeet <= 600) ;

            {
                lblDisplayWKS.Text = $"20";
            }
            
            



                   if (Squarefeet <= 100) ;
            {
                lblArea.Text = $"{Squarefeet:c},FT";
            }
 





















            
            



        }
    }
}

        
    

