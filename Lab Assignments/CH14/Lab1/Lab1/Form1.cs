using Microsoft.VisualBasic;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Letter> letters = new List<Letter>(20);

        private void btnSend_Click(object sender, EventArgs e)
        {
            rTxtDisplay.Clear();
            
          
            if (letters.Count == 20)
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text += "You can only have 20 letters";
            }

            else if (txtRecipient.Text != null && txtSent.Text != null && String.IsNullOrEmpty(txtTrackingNumber.Text))
            {

                DateTime SentDate = DateTime.Parse(txtSent.Text);
                letters.Add(new Letter(txtRecipient.Text, SentDate));
                for (int i = 0; i < letters.Count; i++)
                {


                    rTxtDisplay.Text += $"{letters[i]}\n";
                }
            }
            else if (txtRecipient.Text != null && txtSent.Text != null && txtTrackingNumber.Text != null)
            {




                lblErrorMessage.Visible = true;
                letters.Add(new CertifiedLetter(txtRecipient.Text, DateTime.Parse(txtSent.Text), txtTrackingNumber.Text));

                for (int i = 0; i < letters.Count; i++)
                {


                    rTxtDisplay.Text += $"{letters[i]}\n";
                }


            }
        }
    }
}

