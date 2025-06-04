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
            double InputInch = Convert.ToDouble(userInputInch.Text);
            
           double Centimeters = 2.54f;
           double CM_PER_INCH = Centimeters *InputInch;
            

            
            {
                CmDisplay.Text =$"{CM_PER_INCH:f}";
                label1.Text =$"{InputInch} inches and {CM_PER_INCH:f}Centimeters";
            } 

            
        }
    }
}
