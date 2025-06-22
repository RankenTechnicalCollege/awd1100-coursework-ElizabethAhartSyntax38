using System.Drawing.Text;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetWood()
        {
            string userInput1 = (txtBoxWood.Text.ToLower());
            if (!string.IsNullOrEmpty(userInput1))
            {
                return userInput1 switch
                {
                    "m" => "Mahogany",
                    "o" => "Oak",
                    "P" => "Pine",
                    _ => "Other"

                };
            }
            else
            {
                lblDisplayCostW.Text = $"Wood NOT Found";
            }
            return userInput1;
            
           // int UserInput2 = Convert.ToInt32(txtBoxDrawerCount.Text);
            //int NumDrawer = Convert.ToInt32(txtBoxDrawerCount.Text);
            //string UserInput1 = txtBoxWood.Text;


            //string[] WoodChoice = new string[] { "Mahogany", "Oak", "Pine", "Other" };
            //double[] WoodCost = new double[] { 180, 140, 100, 180 };

            //for (int i = 0; i < WoodChoice.Length; i++)

            //    if (WoodChoice[i].Contains(UserInput1.ToLower()))
            //    {
            //        string WoodChoice2 =WoodChoice[i];
            //       double WoodTotal=WoodCost[i];

            //        lblDisplayCostW.Text = $"{WoodChoice[i]},{WoodCost[i]}";
                  
                   
            //    } 
            //    else
            //    {
            //        lblDisplayCostW.Text = $"Wood NOT Found";
                   
            //    }

             
            }
        
        
        private int GetDrawer()

        {
           
            int NumDrawer = Convert.ToInt32(txtBoxDrawerCount.Text);
            return NumDrawer;
            
            
        }
        private double CalculateWoodCost(string Wood)
        {
            return Wood switch
            {
                "Mahogany" => 180,
                "Oak" => 140,
                "Pine" => 100,
                "Other" => 180,
            };
        }
        private double CalculateDrawerCost(int Drawers)
        {
            return Drawers * 30;
        }
        private double CalculateTotalCost(string wood,int drawers)

        {
            double CostOfWood = CalculateWoodCost(wood);
            double CostOfDrawers= CalculateDrawerCost(drawers);
            double totalCost= CostOfWood+CostOfDrawers;
            return totalCost;
        }
        





        private void btnEstimate_Click(object sender, EventArgs e)
        {
            
           string Wood= GetWood();
           int Drawers= GetDrawer();

            lblDisplayCostD.Text = $"Total cost is {Convert.ToString(CalculateDrawerCost(Drawers))}";
            lblDisplayCostW.Text = $"Your wood cost is {Convert.ToString(CalculateWoodCost(Wood))}";
            lblDisplayTotal.Text = $"Your Total Cost is {Convert.ToString(CalculateTotalCost(Wood, Drawers))}";



            }
        }
    }


