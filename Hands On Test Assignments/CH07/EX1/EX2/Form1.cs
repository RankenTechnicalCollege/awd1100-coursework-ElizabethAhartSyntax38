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
                MessageBox.Show(" A Format exemption has occurred. Please check all Entries.");
            }

        }

        private void btnExemption2_Click(object sender, EventArgs e)
        {
            txtExemption.Clear();
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtExemption2.Text);
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("ArithmeticException has occurred");
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
                decimal monthlyInvestment = Convert.ToDecimal(txtExemption2.Text);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("InvalidCastException has occurred");
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
                decimal monthlyInvestment = Convert.ToDecimal(txtExemption2.Text);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NullReferenceException has occurred");
            }
            finally
            {
                MessageBox.Show("NullReferenceException has occurred");
            }

        }
    }
}
