using System.Drawing.Text;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Login(string AccNum,string Pin)
        {
            string[] AccountNumber = {"5551212","5554242","5556363","5558787","5551111","5559595","5554747","5554141"};
            string[] PinNum = {"1234","2345","3333","6545","1212","6060","1515","8787"};
            decimal[] AccountBalance = { 100000m, 10000m, 10000, 10000m, 10000m, 10000m, 10000m, 10000m,};
           int AccountBal = 10000;
           char[] ReplacementChar = new char[] { '#' };
            
           
            for (int i = 0; i <ReplacementChar.Length; i++)
            {
                if (txtAccount.Text.Contains(AccountNumber[i]))
                {
                    btnLog.Enabled = true;
                    lblDisplayWelcome.Text = "Welcome Account Member ";
                    lblDisplayAccountBal.Text = $"Your Account Balance is {AccountBal:c}";
                    lblDisplayPrompt.Text = $"Would you like to deposit OR Make a Withdraw? AccountMember {AccountNumber[i]}";
                }else if (txtPin.Text.Contains(PinNum[i]))
                {
                    btnLog.Enabled = true;
                    lblDisplayWelcome.Text = "Welcome Account Member ";
                    lblDisplayAccountBal.Text = $"Your Account Balance is {AccountBal:c}";
                    lblDisplayPrompt.Text = $"Would you like to deposit OR Make a Withdraw? AccountMember {AccountNumber[i]}";
                }
                txtPin.Clear();
                txtAccount.Clear();
            }
            
                
             

        }
        private void MakeDeposit()
        {
            decimal UserInputDepo = Convert.ToDecimal(txtboxDeposit.Text);
            decimal AccountBal = 10000;
            if (UserInputDepo > 0)
            {
               UserInputDepo = AccountBal + UserInputDepo;
                lblDisplayAccountBal.Text = $"Yor New Balance is {UserInputDepo:c}";
            }
        }
        private void MakeWithdraw()
        {

            decimal UserInputWith = Convert.ToDecimal(txtBoxwithdraw.Text);
            decimal AccountBal = 10000;
            if (UserInputWith > 0)
            {
                UserInputWith = AccountBal - UserInputWith;
                {
                    lblDisplayAccountBal.Text = $"Your Updated Balance is {UserInputWith:c}";
                }
            }
            txtboxDeposit.Clear();
        }
        private void LogOut()
        {
            txtboxDeposit.Enabled = false;
            txtboxDeposit.Clear();
            txtBoxwithdraw.Enabled = false;
            txtBoxwithdraw.Clear();
            txtAccount.Clear();
            txtPin.Clear();
            txtPin.Enabled=true;
            txtAccount.Enabled = true;
        }

        
        private void btnLog_Click(object sender, EventArgs e)
        {

            Login("1", "1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeDeposit();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            MakeWithdraw();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
