using System.Text.RegularExpressions;

namespace lLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Parsebid(string bid)
        {
            bid = Regex.Replace(bid, @"\s+", String.Empty);
            bid = Regex.Replace(bid, @"[^0-9.]", "");


            return bid;
        }
        
            
        private void btnBid_Click(object sender, EventArgs e)
        {
            string bid = Parsebid(txtbox1.Text);
            string UserInput1 = Convert.ToString(txtbox1.Text);
            if (Convert.ToDecimal(bid) > 10)
            {
                lblDisplay.Text = $"Bid of {UserInput1} is Accepted";

            }
            
                
               
                
        }
    }
}

