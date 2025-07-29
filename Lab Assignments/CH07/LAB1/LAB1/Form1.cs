namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          decimal height =Convert.ToDecimal(txtHeight.Text.ToString());
           decimal Weight =Convert.ToDecimal(txtWeight.Text.ToString());
           
            if (height > 129 || Weight > 129)
            {
                BMI myWeight = new BMI();
                lblDisplay.Text = $"{WeightCategory.OverWeight}";
            }
            else if (height < 130 || Weight < 130)
            {
                lblDisplay.Text =$"{WeightCategory.Normal}";
            }
            else
            {
                MessageBox.Show(txtHeight.Text);

                
            }


        }
    }
}
