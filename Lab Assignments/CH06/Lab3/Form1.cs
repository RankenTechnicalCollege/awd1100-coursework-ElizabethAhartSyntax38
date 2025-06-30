using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Prices = new string[] { "34 dollars", "34.00 dollars", "34.0 dollars", };

        
        private void btnBid_Click(object sender, EventArgs e)
        {
           int userInput=Convert.ToInt32(txtboxBid);
            lblDisplay.Text = userInput.ToString();
            
        }


            
        
        }
    }

            
           


        
    


