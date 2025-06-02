using System.Reflection.Metadata;

namespace HandOnTest05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal InputInch = Convert.ToDecimal(userInputInch.Text);
            
            decimal Centimeters = InputInch * 30;
            Constant CM_PER_INCH=new Constant();
            
            {
                CmDisplay.Text =$"{Centimeters}";
            } 

            
        }
    }
}
