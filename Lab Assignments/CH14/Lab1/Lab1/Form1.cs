using Microsoft.VisualBasic;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
           
            if (txtRecipient != null && txtSent != null)
            {

               DateTime SentDate = DateTime.Parse(txtSent.Text);
                Letter L1 = new Letter(txtRecipient.Text, DateOnly.MaxValue, 50);
                Letter[] Letter = new Letter[20];
                rTxtDisplay.Text = $"{L1}\n";

            }
            else if (txtRecipient != null && txtSent != null && txtTrackingNumber != null)

            
                lblErrorMessage.Visible = true;
            CertifiedLetter L2=new CertifiedLetter(txtRecipient.Text,DateOnly.MinValue, 50);
            CertifiedLetter[] CERTMAIL = new CertifiedLetter[20];
            rTxtDisplay.Text = $"{L2}\n";
            }
        }
    }

