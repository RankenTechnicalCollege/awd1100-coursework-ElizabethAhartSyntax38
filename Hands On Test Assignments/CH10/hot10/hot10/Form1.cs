namespace hot10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] Occasion = { "InLove", "HappyBirthday", "Thankyou" };
            foreach (string o in Occasion)
            {
                cmbBoxOcc.Items.Add(o);
            }
            string[] Style = { "Flowers", "Hearts" };
            foreach (string style in Style)
            {
                cmbBoxStyle.Items.Add(style);

            }

            string Order = cmbBoxOcc.SelectedIndex.ToString();
            {
                pcBoxFlower.Visible = true;
                pcBoxHearts.Visible = true;
            }


            string StyleOrder = cmbBoxStyle.SelectedIndex.ToString();


            
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbBoxOcc.Items.Count; i++)
            
            if (chckBoxENv.Checked )
            {
                new  Order(cmbBoxOcc.ToString(), true, true,18);
             
               
            }
            if (chckBoxStamp.Checked||chckBoxENv.Checked) 
            {
                new Order(cmbBoxStyle.ToString(), true, true,18);
                Order myOrder = new Order(cmbBoxStyle.ToString(), true, true,17);
                lblDisplayTotal.Text += $"{myOrder.base_price}";
               
            }
            if (chckBoxMess.Checked )
            {
                rchDisplay.Visible = true;
                
       
            }
            

            pcBoxFlower.Visible = true;
            pcBoxHearts.Visible = true;

        }
    }
}
