using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MakeDeposit()
        {
            rchPrinter.Clear();
            string UserInputA = txtAccount.Text;
            int balance = 100000;
            int Deposit = Convert.ToInt32(txtDeposit.Text);
            int NewBalance = balance + Deposit;
            rchPrinter.Text += $"\n{NewBalance.ToString()}\n{balance:c}+{Deposit:c}\nTotal:{NewBalance:c}\nUSERNAME ={txtAccount.Text}";
        }
        public void MakeWithDraw()
        {
          rchPrinter.Clear();
            double withdrawFee = .01;
            string UserInputA = txtAccount.Text;
            int balance = 100000;
            int Withdraw = Convert.ToInt32(txtWithDraw.Text);
            int NewWithdraw = balance - Withdraw;
            rchPrinter.Text += $"\n{NewWithdraw.ToString()}\n{balance}-{Withdraw}\nTotal : {NewWithdraw:c}\nUserName={txtAccount.Text:c}\nWithdraw has a 1% fee of {Withdraw*withdrawFee} a NEWBALANCE of {NewWithdraw-(Withdraw*withdrawFee):c} ";

        }
        public void LogOut()
        {
            btnLogOut.Visible = false;
            grpBoxDeposit.Visible = false;
            rchPrinter.Visible = false;
            lblAccount.Visible = true;
            lblPIn.Visible = true;
            txtAccount.Visible = true;
            txtPin.Visible = true;
            txtAccount.Clear();
            txtPin.Clear();
            btnLogin.Visible = true ;
        }
        string[] bankAccounts = new string[5] { "1234567", "0000000", "1111111", "2222222", "33333333" };
        string[] bankAccountsPIN = new string[5] { "1234", "0000", "1111", "2222", "3333" };
        string[] BankAccountsTrain = new string[5] { "$10.\n$20.\n$12\n", "$14.\n$12.\n$25.\n", "$15.\n$10.\n$10\n", "$12.\n$15.\n$10\n", "$20\n$20\n$20\n" };
        string[] MemberType = new string[5] { "Gold", "Bronze", "Silver", "Gold", "Bronze" };
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserInputA = txtAccount.Text;
            string UserInputPin = txtPin.Text;
            for (int i = 0; i < BankAccountsTrain.Length; i++)
            {
                if (bankAccounts[i] == UserInputA && bankAccountsPIN[i] == UserInputPin)
                {
                    int AccountBalance = 10000;
                    lblWelcome.Text = bankAccounts[i] + $"\n You are a {MemberType[i]}Member\nWelcome WELCOME Your Balance is{AccountBalance:c} \n Here are your Options";
                    rchPrinter.Text += BankAccountsTrain[i];
                    grpBoxDeposit.Visible = true;
                    rchPrinter.Visible = true;
                    btnLogin.Visible = false;
                    txtAccount.Visible = false;
                    txtPin.Visible = false;
                    btnLogin.Visible = false;
                    lblAccount.Visible = false;
                    lblPIn.Visible = false;
                    lblPromptDeposit.Visible = true;
                    if (MemberType[i] == "Bronze")
                    {
                        new BronzeMember(txtPin.Text, txtAccount.Text);
                        rchPrinter.Text += new BronzeMember(txtPin.Text, txtAccount.Text);
                    }
                    else if (MemberType[i] == "Gold")
                    {
                        new GoldMember(txtPin.Text, txtAccount.Text);
                        rchPrinter.Text += new GoldMember(txtPin.Text, txtAccount.Text);
                    }
                    else if (MemberType[i] == "Silver")

                    {
                        new SilverMember(txtPin.Text, txtAccount.Text);
                        rchPrinter.Text += new SilverMember(txtPin.Text, txtAccount.Text);

                    }
                  
                    
                        
                     


                }
               
               



            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtDeposit.Text != "" && txtWithDraw.Text == "")
            {
                MakeDeposit();
                btnLogOut.Visible = true;
                txtWithDraw.Clear();
            }
            else if (txtDeposit.Text == "" && txtWithDraw.Text != "")
            {
                MakeWithDraw();
                txtDeposit.Clear();
                btnLogin.Visible = true;
            }
            else
            {
                rchPrinter.Text += "ERROR ERROR PLEASE TRY AGAIN\nONLY ONE TRANSACTION AT A TIME\n";
                btnLogOut.Visible = true;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
    }
}
