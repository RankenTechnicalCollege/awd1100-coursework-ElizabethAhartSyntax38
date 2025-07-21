using System.Drawing.Imaging.Effects;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
           double loanAmount = Convert.ToInt32(txtAmount.Text);


            for (int i = 0; i < 75; i++)

                if (Name == "" || loanAmount < 0)
                {
                    lblDisplayAmount.Text = "INVALID LOAN REFERENCE";

                }
                else if (Name != null && chkShort.Checked || loanAmount >= 0 && chkLONG.Checked)
                {
                    grpManage.Visible = true;
                    lblDisplayName.Text = $"{Name} and {loanAmount}";
                    lblDisplayAmount.Text = loanAmount.ToString();

                    short myLoan = new short();
                    lblDisplay.Text = $"{new short()}";
                    List<short> list = new List<short>(20);

                }
                else if (Name != null && chkLONG.Checked || loanAmount > 0 && chkShort.Checked)
                {

                    LongTerm myLoan = new LongTerm();
                    List<LongTerm> list = new List<LongTerm>(20);
                    lblDisplay.Text = $"{new LongTerm()}";


                }
                else { lblDisplayAmount.Text = "Invalid Loan Amount/Name"; }

        }
        private void MakePayment()
        {
           double loanAmount = Convert.ToInt32(txtAmount.Text);
            double balance = loanAmount;
            double Payment = 450f;
            if (Payment > 0)
            {
                balance = balance - Payment;
                lblDisplayLoan.Text =$"{ balance.ToString():c}\n";
            }
        }
        private void ApplyInterest()
        {
          double loanAmount = Convert.ToInt32(txtAmount.Text);
            
            double Payment = 450f;
            double balance =loanAmount-Payment;
            double interest =450 * .007;
            double loanBalance = Convert.ToDouble(balance+interest);
            lblDisplayLoan.Text +=$"After payment you Owe * {balance.ToString():c}\n";
            lblDisplayLoan.Text += $"After Interest You still owe {loanBalance.ToString():c}";


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            MakePayment();
            ApplyInterest();
            
        }
    }
}

