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
            string[] AccountNumber = txtAccount.Text.Split(',');
            string[] PinNum = txtPin.Text.Split(',');
            int AccountBal = 10000;
            int i = 0;
            char[] ReplacementChar = new char[] { '#' };
            do
            {
                btnLog.Enabled = true;
                lblDisplayWelcome.Text = "Welcome Account Member ";
                lblDisplayAccountBal.Text = $"Your Account Balance is {AccountBal:c}";
                lblDisplayPrompt.Text = $"Would you like to deposit OR Make a Withdraw? AccountMember {AccountNumber[i]}";
            } while (AccountNumber.Length >= i);

        }
        private void MakeDeposit(decimal DepositAmount)
        {
            decimal UserInputDepo = Convert.ToDecimal(txtboxDeposit.Text);
            decimal AccountBal = 10000;
            if (DepositAmount < 0)
            {
                DepositAmount = AccountBal + UserInputDepo;
                lblDisplayAccountBal.Text = $"Yor New Balance is {DepositAmount:c}";
            }
        }
        private void MakeWithdraw(decimal WithdrawAmount)
        {
            decimal UserInputWith = Convert.ToDecimal(txtBoxwithdraw.Text);
            decimal AccountBal = 10000;
            if (WithdrawAmount < 0)
            {
                WithdrawAmount = AccountBal - UserInputWith;
                {
                    lblDisplayAccountBal.Text = $"Your Updated Balance is {WithdrawAmount:c}";
                }
            }
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
            MakeDeposit(1);

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            MakeWithdraw(1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
