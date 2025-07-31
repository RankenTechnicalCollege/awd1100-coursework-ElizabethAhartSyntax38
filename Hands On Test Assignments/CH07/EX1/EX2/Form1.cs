using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemption_Click(object sender, EventArgs e)
        {
            Investments[] invest =new Investments[1];
            lblPrompt.Text = Convert.ToString(new Investments[1]); 
            try
            {
                decimal MonthlyInvestment = Convert.ToDecimal(txtExemption.Text);
             

            }
            catch (FormatException)
            {
                MessageBox.Show(" A Format exemption has occurred. Please check all Entries. now");
            }

        }

        private void btnExemption2_Click(object sender, EventArgs e)
        {
            txtExemption.Clear();
            Investments[] invest = new Investments[1];
            lblExemption3.Text = Convert.ToString(new Investments[1]);
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtExemption2.Text);
                decimal Interst = 15m/monthlyInvestment;
                decimal animalPrint=monthlyInvestment*Interst;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("ArithmeticException has occurred now");
            }
           
          
           

        }

        private void btnExemption3_Click(object sender, EventArgs e)
        {
            txtExemption2.Clear();
            Investments[] invest = new Investments[1];
            lblExemption3.Text = Convert.ToString(new Investments[1]);
            try
            {
                int monthlyInvestment = Convert.ToInt32(txtExemption2.Text);
     
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("InvalidCastException has occurred now");
            }
            finally
            {
                MessageBox.Show("InvalidCastException has occurred");
            }

        }

        private void btnExemption4_Click(object sender, EventArgs e)
        {
            txtExemption3.Clear();
            Investments[] invest = new Investments[1];
           
                lblExemption4.Text = Convert.ToString(new Investments[1]);
            try
            {
               
                string? codeInvestment=null;
                 string monthlyInvestment =Convert.ToString( txtExemtion4.Text);
                string UserInput = monthlyInvestment + codeInvestment;
               if (codeInvestment == null && !string.IsNullOrEmpty(txtExemtion4.Text))
                {

                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException has occurred now");
            }
            finally
            {
                MessageBox.Show("Invalid NullReferenceException has occurred");
            }


        }
    }
}
