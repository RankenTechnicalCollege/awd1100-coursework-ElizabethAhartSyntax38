using System.Reflection.Metadata;

namespace lab3
{
    public partial class Form1 : Form
    {
        const decimal PERCENCENT_PER_RAISE= (1.04m);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal salaryEmp1 = Convert.ToDecimal(txtsalary1.Text);
            decimal salaryemp2 = Convert.ToDecimal(txtsalary2.Text);
            decimal salaryemp3 = Convert.ToDecimal(txtsalary3.Text);
            decimal emp12026 = (salaryEmp1 * PERCENCENT_PER_RAISE);
            decimal emp12027 = (emp12026 * PERCENCENT_PER_RAISE);
            decimal emp22026 = (salaryemp2 * PERCENCENT_PER_RAISE);
            decimal emp22027 = (emp22026 * PERCENCENT_PER_RAISE);
            decimal emp32026 = (salaryemp3 * PERCENCENT_PER_RAISE);
            decimal emp32027 = (emp32026 * PERCENCENT_PER_RAISE);
            lblemp12026.Text =String.Format("{0:c}",emp12026);
            lblemp12027.Text =String.Format("{0:c}",emp12027);
            lblemp22026.Text = String.Format("{0:c}", emp22026);
            lblemp22027.Text= String.Format("{0:c}",emp22027);
            lblemp32026.Text = String.Format("{0:c}", emp32026);
            lblemp32027.Text = String.Format("{0:c}", emp32027);
        }
    }
}
