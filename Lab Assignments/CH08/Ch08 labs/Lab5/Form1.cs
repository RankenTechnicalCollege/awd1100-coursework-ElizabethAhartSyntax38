namespace Lab5
{
    public partial class lblDisplay : Form
    {

        

        public lblDisplay()
        {
            InitializeComponent();

            {

            }
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            string userInput1=Convert.ToString(textBox1.Text);
            char[] CardNumber = userInput1.ToCharArray();
            //string[] CreditCard = new string[
            //
            //];
            

            
            for (int i = 0; i < CardNumber.Length; i++)
            {
                if (Char.IsDigit(CardNumber[i]) == true && i < (CardNumber.Length - 4))
                {
                    CardNumber[i] = '#';
                }
                else if (Char.IsWhiteSpace(CardNumber[i]) == true && i < CardNumber.Length - 4)
                {
                    CardNumber[i] = CardNumber[i];

                }
                else 
                {
                    CardNumber[i]=CardNumber[i];
                   
                }
                
            }
            string MaskedCardNum = new string(CardNumber);
                lblDisplayNum.Text = MaskedCardNum.ToString();
        }
        

    }
}


