using System.Runtime.Serialization.Json;
using System.Web;

namespace Lab4
{
    public partial class Form1 : Form
    {
        string[] FIRSTNAMES = new string[8] { "ELIZABETH", "JOHN", "CHRIS", "AZOR", "SOLOMON", "STEVEN", "CJALEXANDER", "ALBA" };
        string[] LASTNAMES = new string[8] { "MARIE", "ARTIFICERJJ", "BROWN", "NICHOLAS", "AHART", "NOAH", "JOHN", "PARKER" };
        string[] COURSE = new string[8] { "AWD PROGRAMMING", "AWD PROGRAMMING", "ELEM-Graphing/INTERMEDIATE", "BUS 110", "INTERMEDIATE ALGEBRA", "NETWORKING 112", "ADMINISTRATION IN 111", "Awd PROGRAMMING" };
        char[] GRADE = { 'A', 'B', 'C', 'A', 'B', 'C', 'A', 'B' };
        double[] GPA = { 3.5, 4.0, 3.0, 2.9, 3.7, 2.5, 4.0, 3.9 };



        public Form1()
        {
            InitializeComponent();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {


            string UserInput = txtFirst.Text.ToLower().ToString();

            for (int i = 0; i < FIRSTNAMES.Length; i++)
            {
                if (UserInput.Contains(FIRSTNAMES[i].ToLower()))
                {
                    lblDisplayName.Text = $"{FIRSTNAMES[i]}\n{LASTNAMES[i]}";
                    lblCourseDisplay.Text = COURSE[i];
                    lblGAPADisplay.Text = Convert.ToString(GPA[i]);
                    lblGradeDisplay.Text = GRADE[i].ToString();
                    lblERROR.Visible = false;
                    break;

                }

                else
                {
                    lblERROR.Visible = true;
                }
                txtFirst.Clear();
            }
        }
        private void btnLastName_Click(object sender, EventArgs e)
        {
            string UserInput1 = txtLastNames.Text.ToLower().ToString();

            for (int i = 0; i < LASTNAMES.Length; i++)
            {
                if (UserInput1.Contains(LASTNAMES[i].ToLower()))
                {
                    lblDisplayName.Text = $"{FIRSTNAMES[i]}\n{LASTNAMES[i]}";
                    lblCourseDisplay.Text = COURSE[i];
                    lblGAPADisplay.Text = Convert.ToString(GPA[i]);
                    lblGradeDisplay.Text = GRADE[i].ToString();
                    lblERROR.Visible = false;
                    break;

                }
                else
                {
                    lblERROR.Visible = true;
                }


            }
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFirst_Click(sender, e);
            }
        }
    }
}
    






    

