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
         decimal height = Convert.ToDecimal(txtHeight.Text.ToString());
           decimal Weight =Convert.ToDecimal(txtWeight.Text.ToString());
            float Height = Convert.ToSingle(txtHeight.Text.ToString());
            float weight=Convert.ToSingle(txtWeight.Text.ToString());

            if (height > 129 || Weight > 129)
            {
                BMI myWeight = new BMI(Height, weight,txtHeight.Text.Length, WeightCategory.Normal);
                lblDisplay.Text = $"{WeightCategory.Normal}";
            }
            else if (height > 130 || Weight > 130)
            {
                BMI myWeight = new BMI(Height, weight, txtHeight.Text.Length, WeightCategory.Obese);
                lblDisplay.Text =$"{WeightCategory.Obese}";
            }
            else
            {
                MessageBox.Show(txtHeight.Text);

                
            }


        }
    }
}
