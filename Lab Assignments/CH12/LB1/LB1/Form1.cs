using System.Diagnostics.Eventing.Reader;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private Order anOrder;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
       

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string userName = txtName.Text;
           
            if (chkSoda.Checked || chkSundae.Checked && !string.IsNullOrEmpty(userName))
            {
               
                lblDisplayTotal.Visible = true;
                lblTotalprompt.Visible = true;
                grpSoda.Visible = true;
                grpBoxSundae.Visible = true;
               
                anOrder = new Order(userName, chkSundae.Checked, chkSoda.Checked);

                if (chkBoxSprinkles.Checked && chkBoxNuts.Checked && chkBoxSyrup.Checked)
                {
                    lblToppingError.Visible = true;
                }
                else
                {
                    lblToppingError.Visible = false;
                }
                if (chkBoxSprinkles.Checked)
                {
                    anOrder.sundae.AddToppings(SundaeToppings.SPRINKLES);

                }
                if (chkBoxNuts.Checked) anOrder.sundae.AddToppings(SundaeToppings.NUTS);

                if (chkBoxSyrup.Checked) anOrder.sundae.AddToppings(SundaeToppings.CHOCOLAT_SYRUP);

                if (chkboxLime.Checked && chkBoxPeach.Checked || chkboxLime.Checked && chkBoxMango.Checked || chkBoxMango.Checked && chkBoxPeach.Checked)
                {
                    lblSodaError.Visible = true;

                }

                if (chkBoxMango.Checked) anOrder.Soda.AddFlavor(sodaFlavor.MANGO);
                if (chkBoxPeach.Checked) anOrder.Soda.AddFlavor(sodaFlavor.PEACH);
                if (chkboxLime.Checked) anOrder.Soda.AddFlavor(sodaFlavor.LIME);

            }
        }

        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked) { grpBoxSundae.Visible = true; }
            else
            { 
                grpBoxSundae.Visible = false;

            }
        
          
            //rchTxtBox.Text += anOrder.Name;
            //rchTxtBox.Text += "\n******************************";
            

            }
       

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            grpSoda.Visible = chkSoda.Checked ? true:false;
       

        }
    }
}
