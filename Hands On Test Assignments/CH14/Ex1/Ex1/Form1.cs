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
                else if (Name != null && chkShort.Checked || loanAmount >= 0 && chkShort.Checked)
                {
                    grpManage.Visible = true;
                    lblDisplayName.Text = $"{Name} and {loanAmount}";
                    lblDisplayAmount.Text = loanAmount.ToString();

                    ShortTerm_Loan myLoan = new ShortTerm_Loan();
                    lblDisplay.Text = $"{new ShortTerm_Loan()}";
                    List<ShortTerm_Loan> list = new List<ShortTerm_Loan>(20);

                }
                else if (Name != null && chkLONG.Checked || loanAmount > 0 && chkLONG.Checked)
                {
                    grpManage.Visible = true;
                    lblDisplayName.Text = $"{Name} and {loanAmount}";
                    lblDisplayAmount.Text = loanAmount.ToString();

                    LongTerm myLoan = new LongTerm();
                    List<LongTerm> list = new List<LongTerm>(20);
                    lblDisplay.Text = $"{new LongTerm()}";
               


                }
                else { lblDisplayAmount.Text = "Invalid Loan Amount/Name";  }
    
            

        }
        private void MakePayment()
        {

            if (chkShort.Checked)
            {
                List<ShortTerm_Loan> payment = new List<ShortTerm_Loan>(20);
                double loanAmount = Convert.ToDouble(txtAmount.Text);
                double balance = loanAmount;
                double Payment = 450f;

                double Newbalance = balance - Payment;
                lblDisplayLoan.Text += $"{Newbalance.ToString():c}\n";
                lblDisplayLoan.Text += $"After payment you Owe * {Newbalance.ToString():c}\n";

            }
            else if (chkLONG.Checked)
            {
                double loanAmount = Convert.ToDouble(txtAmount.Text);
                double balance = loanAmount;
                List<LongTerm> payment = new List<LongTerm>(20);
                double Payment2 = balance - 200;
                double Newbalance2 = Payment2;
                lblDisplayLoan.Text += $"{Newbalance2.ToString():c}\n";
                lblDisplayLoan.Text += $"After payment you Owe * {Newbalance2.ToString():c}\n";




            }
        }
            
            


        private void ApplyInterest()
        {
            double loanAmount = Convert.ToInt32(txtAmount.Text);
            if (chkShort.Checked)
            {
                List<ShortTerm_Loan> interest1 = new List<ShortTerm_Loan>(20);

                double balance = loanAmount-450;
                double interest = 450 * .010;
                double loanBalance = Convert.ToDouble(balance + interest);
                lblDisplayLoan.Text += $"After payment you Owe * {balance.ToString():c}\n";
                lblDisplayLoan.Text += $"After Interest You still owe {loanBalance.ToString():c}";
               

                if (chkLONG.Checked)
                {
                    List<LongTerm> interest10 = new List<LongTerm>(20);

                    double balance2 = loanAmount-200;
                    double interest2 = loanAmount * .005;
                    double loanBalance2 = Convert.ToDouble(balance2 + interest2);
                    lblDisplayLoan.Text += $"After payment you Owe  {balance2.ToString():c}\n";
                    lblDisplayLoan.Text += $"After Interest You still owe {loanBalance2.ToString():c}";
                    lblDisplayLoan.Text += $"{loanAmount} was loaned";

                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

             MakePayment();
            ApplyInterest();
                  
            
               

              
           

        }
    }
}

