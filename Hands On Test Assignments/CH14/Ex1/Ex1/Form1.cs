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
                string Name=txtName.Text;
                 int loanAmount=Convert.ToInt32(txtAmount.Text);
            double balance = loanAmount;

            for (int i = 0; i < 75; i++)

                if (Name == "" || loanAmount < 0 )
            {
                lblDisplayAmount.Text = "INVALID LOAN REFERENCE";
                
            }
            else if (Name !=null && chkShort.Checked|| loanAmount >=0 &&chkLONG.Checked)
            {
                grpManage.Visible = true;
                
                     short myLoan = new short();
                     lblDisplay.Text = $"{new short()}";
                     List<short> list = new List<short>(20);
                
            }
            else if (Name != null && chkLONG.Checked|| loanAmount > 0 &&chkShort.Checked)
            {
                
                     LongTerm myLoan = new LongTerm();
                     List <LongTerm> list = new List<LongTerm>(20);
                     lblDisplay.Text = $"{new LongTerm()}";
                   
                
            }

        }
        }
    }

