namespace Ch6Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reverse4(ref string Num1, ref string Num2, ref string Num3, ref string Num4)
        {
            string Number1 = txtboxNum1.Text;
            string Number2 = txtBoxNum2.Text;
            string Number3 = txtBoxNum3.Text;
            string Number4 = txtBoxNum4.Text;
          lblDisplay.Text =$" Your Numbers In reverse ARE : {Number4}{Number3}{Number2}{Number1}";
          
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string Number1 = txtboxNum1.Text;
            string Number2 = txtBoxNum2.Text;
            string Number3 = txtBoxNum3.Text;
            string Number4 = txtBoxNum4.Text;
            Reverse4(ref Number1, ref Number2, ref Number3, ref Number4);

            

        }
    }
}
