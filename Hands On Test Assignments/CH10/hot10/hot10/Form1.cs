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
                
            }
            

            string StyleOrder = cmbBoxStyle.SelectedIndex.ToString();
               

            if (chckBoxENv.Checked)
            {
               new Order(cmbBoxOcc.ToString(), true,true);
               
        
            }
            if (chckBoxStamp.Checked)
            {
                new Order(cmbBoxStyle.ToString(), true, true);
            }
            if (chckBoxMess.Checked)
            {
                
                lblDisplayFlowers.Visible = true;
                lblDisplayHearts.Visible = true;
                new Order(cmbBoxOcc.ToString(), true,true);
            }
            pcBoxFlower.Visible = true;
            pcBoxHearts.Visible = true;
        }
    }
}
