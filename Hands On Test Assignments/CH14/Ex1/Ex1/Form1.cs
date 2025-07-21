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
            if (txtName == null || txtAmount == null)
            {
                lblDisplay.Text = "INVALID LOAN REFERENCE";
            }
            else if (txtAmount.Text != null && chkShort.Checked|| txtName.Text != null&&chkLONG.Checked)
            {
                grpManage.Visible = true;
                string CreateLoanShort(string name, int amount)
                {

                    short myLoan = new short();
                    lblDisplay.Text = $"{new short()}";
                    return $"{Name,10000}";
                }
            }
            else if (txtAmount.Text != null && chkLONG.Checked||  txtName.Text != null&&chkShort.Checked)
            {
                string CreateLong(string name, int amount)
                {
                    LongTerm myLoan = new LongTerm();
                    lblDisplay.Text = $"{new LongTerm()}";
                    return $"{name} {amount}";
                }
            }

        }
        }
    }

