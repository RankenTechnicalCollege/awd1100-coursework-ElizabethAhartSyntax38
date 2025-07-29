using static System.Net.Mime.MediaTypeNames;

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
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtExemption2.Text);
                decimal Interst = 15m*10;
                decimal animalPrint=monthlyInvestment*Interst;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("ArithmeticException has occurred now");
            }
            finally
            {
                MessageBox.Show("ArithmeticException has occurred");
            }

        }

        private void btnExemption3_Click(object sender, EventArgs e)
        {
            txtExemption2.Clear();
            try
            {
                int monthlyInvestment = Convert.ToInt32(txtExemption2.Text);
                lblExemption3.Text=monthlyInvestment.ToString();
                
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
            try
            {
                int monthlyInvestment = Convert.ToInt32(txtExemption2.Text = null);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException has occurred now");
            }
            finally
            {
                MessageBox.Show("NullReferenceException has occurred");
            }

        }
    }
}
