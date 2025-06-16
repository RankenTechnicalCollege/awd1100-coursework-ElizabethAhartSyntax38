namespace PROJECT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] FirstNames = new string[] { "MARKEL", "LUIZA", "BRYONY", "GIRALDO", "LOWRI" };
            string[] LastNames = new string[] { "DIGGORY", "GUNNAR", "HESTER", "ADDY", "HARI" };
            string[] PhoneNumber = new string[] { "555-8390", "555-4618", "555-4440", "555-1687", "555-7763" };
            string userInput1 = txtBox1.Text.ToUpper();
            for (int i = 0; i < FirstNames.Length; i++)
            {
                if (userInput1.ToUpper().Contains(FirstNames[i]) == true || userInput1.ToUpper().Contains(LastNames[i]) == true) 
                {
                    lblDisplayFirst.Text = $"{FirstNames[i]}";
                    lblDisplayLast.Text = $" {LastNames[i]}";
                    lblDisplayPhone.Text = $"{PhoneNumber[i]}";
                    break;
                }
                else 
                {
                    lblDisplayPhone.Text = "ERROR";
                    lblDisplayLast.Text = "ERROR";
                    LblFirstName.Text = "ERROR";
              
                }
            }
        }
    }
}
