using System.Diagnostics.Eventing.Reader;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {


            //    int[] zipCodeAmount = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    int[] Deliverycharge = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    string zipcode1 = Convert.ToString(Console.ReadLine());

            //    List<int> zipcodes = new List<int>()
            //{ 63101,63103,63105,63109,63113,63118,63130,63133,63136,63137};

            //    List<int> DeliveryCharge = new List<int>()
            //{ 20, 12, 25, 15, 10, 23, 18, 20, 17, 12 };

            string userInput = txtBox1.Text;
            string[] zipcodeAmount = new string[] { "63101", "63103", "63105", "63109", "63113", "63118", "63130", "63133", "63136", "63137" };
            string[] DeliveryCharge1 = new string[] { "20", "12", "25", "15", "10", "23", "18", "20", "17", "12" };

            for (int i = 0; i < zipcodeAmount.Length; i++)
            {
                if (zipcodeAmount[i].Contains(userInput))
                {
                    lblDisplay.Text = $"Delivery Charge will be {DeliveryCharge1[i]}";
                    break;


                } else
                {
                    lblDisplay.Text = $"Your ZipCode Not Found!";


                }
            }
           txtBox1.Clear();
        }
    }
}   

