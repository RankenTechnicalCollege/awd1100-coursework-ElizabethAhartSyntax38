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
        private void MaskNumber(string MaskedNumber,char ReplacementChar,int NumDigitsToPreserve)
        {
            string userInput1 = Convert.ToString(textBox1.Text);
            char[] CardNumber = userInput1.ToCharArray();
            int Preserve = 4;
            char replacementChar = '#';

            for (int i = 0; i < CardNumber.Length; i++)
            {
                if (Char.IsDigit(CardNumber[i]) == true && i < (CardNumber.Length - 4))
                {
                    CardNumber[i] = '#';
                    Preserve++;
                }
                else if (Char.IsWhiteSpace(CardNumber[i]) == true && i < CardNumber.Length - 4)
                {
                    CardNumber[i] = CardNumber[i];
                    Preserve++;

                }
                else
                {
                    CardNumber[i] = CardNumber[i];
                    Preserve++;

                }

            }
            string MaskedCardNum = new string(CardNumber);
            lblDisplayNum.Text = MaskedCardNum.ToString();
            


        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            MaskNumber("1",'a',1);
        }
        

    }
}


