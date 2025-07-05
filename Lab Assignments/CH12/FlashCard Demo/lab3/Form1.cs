namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDisplay.Visible = false;
            lblDeposit.Visible = false;
            txtDeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblWithdraw.Visible = false;
            lblName.Visible = true;
            txtName.Visible = true;
            btnAccess.Visible = true;
            txtPin.Visible = true;
            txtAccNum.Visible = true;
            lblPin.Visible = true;
            lblAcc.Visible = true;
            btnLogOut.Visible = false;
            btnEnter.Visible = false;
            btnDeposit.Visible = false;
        }
        private void LogIn(string Number, string Pin)
        {
            string Name = txtName.Text;
            string AccountNumber = txtAccNum.Text;
            string PinNumber = txtPin.Text;
            lblDeposit.Visible = true;
            txtDeposit.Visible = true;
            txtDisplay.Visible = true;
            txtWithdraw.Visible = true;
            lblWithdraw.Visible = true;
            btnAccess.Visible = false;
            txtPin.Visible = false;
            txtAccNum.Visible = false;
            lblPin.Visible = false;
            lblAcc.Visible = false;
            btnLogOut.Visible = true;
            btnEnter.Visible = true;
            lblName.Visible = false;
            txtName.Visible = false;
            btnDeposit.Visible=true;
            txtDisplay.Text = $"Welcome {Name}  AccountNumber{AccountNumber} Your Balance is $10,201";
        }
        private void LogOut()
        {

            txtDisplay.Visible = false;
            lblDeposit.Visible = false;
            txtDeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblWithdraw.Visible = false;
            btnAccess.Visible = true;
            txtPin.Visible = true;
            txtAccNum.Visible = true;
            lblPin.Visible = true;
            lblAcc.Visible = true;
            btnLogOut.Visible = false;
            btnEnter.Visible = false;
            btnDeposit.Visible = false;
            txtAccNum.Clear();
            txtPin.Clear();
        }
        private void btnAccess_Click(object sender, EventArgs e)
        {
            string AccountNumber = txtAccNum.Text;
            string PinNumber = txtPin.Text;

            if (txtPin.Text == "1234" || txtPin.Text == "5555")
            {
                LogIn(AccountNumber, PinNumber);



            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private decimal MakeDeposit()
        {
            decimal balance = 10201;
            decimal Deposit = Convert.ToDecimal(txtDeposit.Text);
            txtDisplay.Text = $"Yor New Account Balance is {balance + Deposit:c}";
            return (Deposit + balance);


            new Accounts("name", "PinNumber", "AccountNumber", 10201);
        }
        private Decimal MakeWithdraw()
        {

            txtDisplay.Text = "";
            decimal balance = 10201;
            decimal withdraw = Convert.ToDecimal(txtWithdraw.Text);
            txtDisplay.Text = $"Yor New Account Balance is {balance - withdraw:c}";


            return (withdraw - balance);


        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
           


            MakeWithdraw();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            txtWithdraw.Clear();
            txtDisplay.Clear();
            MakeDeposit();
        }
    }
}
