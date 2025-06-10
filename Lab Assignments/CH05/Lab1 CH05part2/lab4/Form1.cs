namespace lab4
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        decimal DanielleSales = 0m;
        decimal EdwardSales = 0m;
        decimal FrancisSales = 0m;
        decimal TotalSales = 0m;
        decimal HighestSale = 0m;
        // initialize my variables first

        private void btnDaniel_Click(object sender, EventArgs e)
        {
          decimal SalesAmount =Convert.ToDecimal(txtBox1.Text);
            DanielleSales += SalesAmount;
            TotalSales += SalesAmount;
            lbl1.Text =$"Danielle Sales{DanielleSales.ToString()}";
           lblTotal.Text = $"{TotalSales}";
            if (DanielleSales > HighestSale)
            {
                HighestSale = DanielleSales;
                lblHighest.Text = "Danielle has the most in sales";
            }
        }//first button dan and total sale stored variable 

        private void btnEdward_Click(object sender, EventArgs e)
        {
            decimal SalesAmount = Convert.ToDecimal(txtBox1.Text);
            EdwardSales += SalesAmount;
            TotalSales += SalesAmount;
            lbl2.Text = $"Edwards Sales{EdwardSales.ToString()}";
            lblTotal.Text = $"{TotalSales}";
            if (EdwardSales > HighestSale)
            {
                HighestSale = EdwardSales;
                lblHighest.Text = "Edward has the most in sales";
            }
        }

        private void btnFrancis_Click(object sender, EventArgs e)
        {
            decimal SalesAmount = Convert.ToDecimal(txtBox1.Text);

            FrancisSales += SalesAmount;
            TotalSales += SalesAmount;
            lbl3.Text = $"Francis Sales{FrancisSales.ToString()}";
            lblTotal.Text=$"{TotalSales}";
            if(FrancisSales > HighestSale)
            {
                HighestSale = FrancisSales;
                lblHighest.Text = "Francis has the Highest Sales";
            }

        }
        
    } 
}
