namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int NumNights = Convert.ToInt32(txtBoxEntry1.Text);
            int[] NightlyRate = new int[8] { 200, 200, 180, 180, 160, 160, 160, 145 };
            int[] CareFreeResort = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int TotalCost = 0;
            if (NumNights > 0 && NumNights < 50)
            {
                txtTax.Text = "You Welcome to Stay!";

                for (int i = 0; i < NightlyRate.Length; i++)
                {
                    if (NumNights == CareFreeResort[i])
                    {
                        txtNIGHT.Text = NightlyRate[i].ToString();
                        txtTotal.Text = $"{(NightlyRate[i] * NumNights):c}";
                        {

                        }
                    }






                }
            }
        }
    }
}
