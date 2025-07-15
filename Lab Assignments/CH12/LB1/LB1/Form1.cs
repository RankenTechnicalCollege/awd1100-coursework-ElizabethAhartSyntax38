using System.Diagnostics.Eventing.Reader;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
         Order anOrder;
        bool isValid=false;
        double grandTotal = 0;


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isValid=false;
            string userName = txtName.Text;

            if (chkSoda.Checked && !string.IsNullOrEmpty(userName)||chkSundae.Checked && !string.IsNullOrEmpty(userName))
            {

                lblDisplayTotal.Visible = true;
                lblTotalprompt.Visible = true;
                grpSoda.Visible = true;
                grpBoxSundae.Visible = true;

                    anOrder = new Order(userName, chkSundae.Checked, chkSoda.Checked);
                if (chkSundae.Checked)
                {
                    if (chkBoxSprinkles.Checked && chkBoxNuts.Checked && chkBoxSyrup.Checked)
                    {
                        lblToppingError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        lblToppingError.Visible = false;
                        isValid = true;
                        if (chkBoxSprinkles.Checked) anOrder.sundae.AddToppings(SundaeToppings.SPRINKLES);
                        if (chkBoxNuts.Checked) anOrder.sundae.AddToppings(SundaeToppings.NUTS);
                        if (chkBoxSyrup.Checked) anOrder.sundae.AddToppings(SundaeToppings.CHOCOLAT_SYRUP);
                    }
                }
                if (chkSoda.Checked)
                {
                    if (chkboxLime.Checked && chkBoxMango.Checked || chkBoxMango.Checked && chkBoxPeach.Checked || chkBoxPeach.Checked && chkboxLime.Checked)
                    {
                        lblSodaError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        lblSodaError.Visible = false;
                        isValid = true;
                        if (chkBoxMango.Checked) anOrder.Soda.AddFlavor(sodaFlavor.MANGO);                        
                        if (chkBoxPeach.Checked) anOrder.Soda.AddFlavor(sodaFlavor.PEACH);
                        if (chkboxLime.Checked) anOrder.Soda.AddFlavor(sodaFlavor.LIME);                          
                    }
                }
                if (isValid)
                {
                    grandTotal += anOrder.Price;
                   lblDisplayTotal.Visible = true;
                    lblDisplayTotal.Text = grandTotal.ToString("c");
                    rchTxtBox.Text += anOrder.Name;
                    rchTxtBox.Text += "\n*****************************\n";
                    if (anOrder.Soda == null)
                    {
                        DisplaySundae();
                        rchTxtBox.Text += "\n";
                    }
                    else if (anOrder.sundae == null)
                    {
                        DisplaySoda();
                        rchTxtBox.Text += "\n";
                    }
                    else
                    {
                        DisplaySundae();
                        DisplaySoda();
                        rchTxtBox.Text +="\n";
                            
                    }
                }
                                       
                    int ToppingCount = anOrder.sundae._toppingCount;
            }
            else
            {
                lblNameError.Visible=true;
            }
        }
        private void DisplaySundae()
        {
            rchTxtBox.Text += "Sundae******\n";
            int toppingCount=anOrder.sundae._toppingCount;
            if (toppingCount == 0)
            {
                rchTxtBox.Text += anOrder.sundae.GetTopping(0);
            }
            else
            {
                for (int i = 0; i < toppingCount; i++)
                {
                    rchTxtBox.Text += anOrder.sundae.GetTopping(i) + " ";
                }
            }
            rchTxtBox.Text += anOrder.sundae.Price.ToString("c") + "\n";
        }
        private void DisplaySoda()
        {
            rchTxtBox.Text+= "*********Soda ***";
            rchTxtBox.Text += anOrder.Soda.Flavor + " ";
            rchTxtBox.Text += anOrder.Price.ToString("c");
            rchTxtBox.Text += "\n";
        }
        
        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked) { grpBoxSundae.Visible = true; }
            else
            {
                grpBoxSundae.Visible = false;

            }

        }
        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            grpSoda.Visible = chkSoda.Checked ? true : false;


        }

       
       


        }
    }


