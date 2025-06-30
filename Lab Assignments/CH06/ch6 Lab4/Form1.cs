using System.Security.Cryptography.Xml;

namespace ch6_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Numbers = new int[20];
        int count = 0;
        private void CalculateStats(out int min, out int max, out double sum, out double Average, params int[] Numbers)
        {
            sum = 0;
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                }

                if (Numbers[i] > max)
                {
                    max = Numbers[i];
                }
                sum += Numbers[i];



            }
            Average =sum / count;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            double Average;
            double sum;
            if(count == 20)
            {
                CalculateStats(out min, out max, out sum, out Average, Numbers);
                lblDisplayAverage.Text =$"{Average}";
                lblDisplayHigh.Text = $"{max}";
                lblDisplayLow.Text = $"{min}";
                lblDisplaySum.Text = $"{sum}";
                lblDisplayNumEnt.Text = $"{count}/20";
            }
            else
            {
                Numbers[count]=int.Parse(txtBox1.Text);
                count++;
                CalculateStats(out min, out max, out sum, out Average, Numbers);
                lblDisplayAverage.Text = $"{Average}";
                lblDisplayHigh.Text = $"{max}";
                lblDisplayLow.Text = $"{min}";
                lblDisplaySum.Text = $"{sum}";
                lblDisplayNumEnt.Text = $"{count}/20";

            }

         }       

        
        
    }
}
