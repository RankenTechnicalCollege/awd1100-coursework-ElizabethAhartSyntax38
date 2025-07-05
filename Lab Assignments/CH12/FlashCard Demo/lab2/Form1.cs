using System.Linq;
using System.Web;

namespace lab2
{
    public partial class Form1 : Form
    {
        List<storeInventory> inventory = new List<storeInventory>();
        
      
        
       
        string[] StoreInventory=new string[5] {"SUGAR 15 bucks 123123 3 casesPerUnit","T-SHIRTS 10 Bucks 555123 10 Cases Per","HOTSAUCE 24Pk 15Bucks 125125","Wall Mount 12bucks 2pk 157157","Computer 1000bucks 5pk 155155"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUnit.Visible = false;
            txtUnit.Visible =false;
            btnAdd.Visible = false;
            lblInventory.Visible = false;
            lblUnitsPer.Visible = false;
            lblItemName.Visible = false;
            txtInventoryNumber.Visible = false;
            txtItemName.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string AccessKey = Convert.ToString(txtBoxAccess.Text);
            if (txtBoxAccess.Text == "1234")
            {
                lblUnit.Visible = true;
                txtUnit.Visible = true;
                lblInventory.Visible = true;
                btnAdd.Visible = true;
                lblInventory.Visible = true;
                lblUnitsPer.Visible = true;
                lblItemName.Visible = true;
                txtItemName.Visible = true;
                txtInventoryNumber.Visible = true;



            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            lblDisplay.Text = "";
            inventory.Add(new storeInventory());
            inventory[inventory.Count() - 1].InventoryName = Convert.ToString(txtItemName.Text);
            inventory[inventory.Count() - 1].InventoryNumber = Convert.ToInt32(txtInventoryNumber.Text);
            inventory[inventory.Count()-1].UnitPrice = Convert.ToDecimal(txtUnit.Text);
            foreach (storeInventory item in inventory)
            {
                lblDisplay.Text += item.ToString();
                lblDisplay.Text += $"{StoreInventory[3]}";
                lblDisplay.Text += $"{StoreInventory[1]}";

                lblDisplay.Text += $"{StoreInventory[04].ToString()}";
                lblDisplay.Text += $"{StoreInventory[02].ToString()}";
                lblDisplay.Text += $" ARE THE FIVE INVENT ITEMS {new storeInventory()}";
                    
            }
            
        }
    }
}
