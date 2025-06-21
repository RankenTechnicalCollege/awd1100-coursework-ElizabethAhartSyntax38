namespace Lab4
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

       
        private int CalculateTotalArea(int Length, int Width)
        {
            int UserInput1 = Convert.ToInt32(txtLength.Text);

            int UserInput2 = Convert.ToInt32(txtWidth.Text);

            Length = UserInput1;
            Width = UserInput2;

            int TotalArea = (Length * 9 * 2) + (Width * 9 * 2);
            int TotalCost = (TotalArea * 6);

            lblDisplayTotalArea.Text = $"{TotalArea}";
            LblDisplayTotalCost.Text = $"{TotalCost:c}";
            return TotalArea;
            

           
         
        
        }
        private void CalculatePaintEstimate(int Total)
        {
            int userInput1 = Convert.ToInt32(txtLength.Text);

            int userInput2 = Convert.ToInt32(txtWidth.Text);
            Total =(userInput1 + userInput2 * 6);
           
            double CalculatePaintEstimate = 6;
            
            for (int i = 1; i < Total;i++) 
            {

                CalculatePaintEstimate = (CalculatePaintEstimate + Total);
                return;
               
            }


        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {


                 CalculatePaintEstimate(1);
                 CalculateTotalArea(1,2);
            
            

        }
    }
}
