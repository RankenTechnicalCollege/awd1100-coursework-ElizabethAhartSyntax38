namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGpa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnAdmit_Click(object sender, EventArgs e)
        {
            
            Double txtGpa =Convert.ToDouble(Console.ReadLine());
            txtGpa=Convert.ToDouble(txtGpa);
            Double txtAdmissionScore=Convert.ToDouble(Console.ReadLine());
            txtAdmissionScore=Convert.ToDouble(txtAdmissionScore);
            String Accept= (txtGpa>=2 && txtAdmissionScore>=60).ToString();
            lblDidplay.Text = Accept;
            
            if (txtGpa >= 3 == txtAdmissionScore > 60)
            {
                lblDidplay.Text = "Accept".ToString();
            }
            else

            {
                lblDidplay.Text = $"Reject".ToString();
            }
        }
    }
}
