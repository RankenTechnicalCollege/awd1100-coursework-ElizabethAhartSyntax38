namespace Lab5
{
    public partial class Form1 : Form
    {
        List<string> Students = new List<string>(10) { "Elizabeth", "John", "Christopher", "Azor", "Solomon", "CJAlexander", "Steven", "SarahJessica", "Alba", "Stephanie" };

        public Form1()
        {
            InitializeComponent();

            rchTxt1.Text = Convert.ToString(Students.ToString());
            Students.Add("ElizabethA");
            rchTxt1.Text += "Elizabeth\n";
            rchTxt1.Text += "John\n";
            rchTxt1.Text += "Christopher\n";
            rchTxt1.Text += "AZOR\n";
            rchTxt1.Text += "SOLOMON\n";
            rchTxt1.Text += "CJAlexander\n";
            rchTxt1.Text += "Steven\n";
            rchTxt1.Text += "SarahJessica\n";
            rchTxt1.Text += "Alba\n";
            rchTxt1.Text += "Stephanie\n";
            


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string UserInPut = txtAdd.Text;
            Students.Add("");
            rchTxt1.Text += $"{UserInPut}\n";
           int  FoundIndex = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are u sure");
           int foundIndex =1;
          
            string UserInPut1 = txtRemove.Text;
            
            Students.RemoveAt(foundIndex);
            rchTxt1.Text = $"{Students}\n";

        }
    }
}
