using System.Diagnostics.Eventing.Reader;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int windspeed = Convert.ToInt32(txtWindSpeed.Text);
            if (windspeed >= 157) 
            { 
                TxtCategory.Text = "Category5"; 
            }
            else if (windspeed >= 130)
            {
                TxtCategory.Text = "category4";
            }
            else if (windspeed >= 111)
            {
                TxtCategory.Text = "Category3";
            }
            else if (windspeed >= 96)
            {
                TxtCategory.Text = "Category2";
            }
            else if (windspeed >= 74)
            {
                TxtCategory.Text = "category1";
            }
            else
            {
                TxtCategory.Text = "Not a Hurricane!!";

            }
           
        }
    }
}