using System.Drawing.Text;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double GetWood()
        {
            int UserInput2 = Convert.ToInt32(txtBoxDrawerCount.Text);
            int NumDrawer = Convert.ToInt32(txtBoxDrawerCount);
            string UserInput1 = txtBoxWood.Text;
            string[] WoodCHoice = new string[] { "Mahogany", "Oak", "Pine", "Other" };
            double[] WoodCost = new double[] { 180, 140, 100, 180 };
            for (int i = 0; i < 10; i++)

                if (WoodCHoice[i].Contains(UserInput1.ToLower()))
                {
                    string WoodChoice =WoodCHoice[i];
                    double WoodTotal=WoodCost[i];

                    lblDisplayCostW.Text = $"{WoodCHoice[i]},{WoodCost[i]}";
                    return WoodCost[i];
                } 
                else
                {
                    lblDisplayCostW.Text = $"Wood NOT Found";
                   
                }

               
            }

        
        private int GetDrawer()

        {
            double[] WoodCost = new double[] { 180, 140, 100, 180 };
            int NumDrawer = Convert.ToInt32(txtBoxDrawerCount);
            int totalCost = NumDrawer * 30;
            
            {   lblCostDrawer.Text = totalCost.ToString() ;
                
                return totalCost;
            }
        }
        





        private void btnEstimate_Click(object sender, EventArgs e)
        {

            GetWood();
            GetDrawer();

            }
        }
    }


