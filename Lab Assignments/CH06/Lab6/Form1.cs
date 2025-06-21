namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] WoodCHoice = new string[] { "Mahogany", "Oak", "Pine", "Other" };
        Double[] WoodCost = new double[] { 180, 140, 100, 180 };





        private void btnEstimate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {

                int UserInput2 = Convert.ToInt32(txtBoxDrawerCount.Text);
                int NumDrawer = Convert.ToInt32(txtBoxDrawerCount);
                string UserInput1 = txtBoxWood.Text;
                if (WoodCHoice[i].Contains(UserInput1))
                {
                    lblDisplayCostW.Text =$"{WoodCost[i]}" ;
                }


            }
        }
    }
}
