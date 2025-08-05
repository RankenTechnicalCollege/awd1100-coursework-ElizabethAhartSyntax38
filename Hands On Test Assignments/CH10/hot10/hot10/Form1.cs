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

                if (chckBoxENv.Checked || chckBoxMess.Checked)
                {

                    Order myOrder = new Order(cmbBoxStyle.ToString(), true, false, 17);
                    rchDisplay.Visible = true;
                    lblDisplayFlowers.Visible = true;
                    lblDisplayHearts.Visible = true;
                    lblDisplayFlowers.Text = rchDisplay.Text;
                    lblDisplayHearts.Text = rchDisplay.Text;
                    lblDisplayTotal.Text = $"{myOrder.base_price+4}";



                }
                else if (chckBoxStamp.Checked || chckBoxENv.Checked)
                {

                    Order myOrder = new Order(cmbBoxStyle.ToString(), false, true, 17);
                    lblDisplayTotal.Text = $"{myOrder.base_price+2}";

                }
                else
                {
                    Order myOrder = new Order(cmbBoxStyle.ToString(), true, true, 17);
                   
                    lblDisplayTotal.Text += $"{myOrder.base_price}";


                }
            

           

        }
    }
}
