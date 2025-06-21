using System.Drawing.Text;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Login(string AccNum,int AccountBalance)
        {
            string [] AccountNumber = txtAccount.Text.Split(',');
            string[] PinNum = txtPin.Text.Split(',');
            int AccountBal = 10000;
            int i = 0;
            char[] ReplacementChar =new char[] {'#' };
            do
            {
                btnLog.Enabled = true;
                lblDisplayWelcome.Text = "Welcome Account Member ";
                lblDisplayAccountBal.Text=$"Your Account Balance is {AccountBal:c}";
            } while (AccountNumber.Length >= i);
            
            }
        
         
        private void btnLog_Click(object sender, EventArgs e)
        {
            
            Login("1",1);
        }
    }
}
