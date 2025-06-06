namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chicken1 = Convert.ToInt32(num1.Text);

            int Chicken2 = Convert.ToInt32(num2.Text);
            int Chicken3 = Convert.ToInt32(num3.Text);
            int chicken4 = Convert.ToInt32(num4.Text);
            int Totaleggs = chicken1 + Chicken2 + Chicken3 + chicken4;
            int dozens = Totaleggs / 12;
            int remander = Totaleggs % 12;
            lblDisplay.Text = $"dozens{dozens}and {remander}eggs";

        }
    }
}
