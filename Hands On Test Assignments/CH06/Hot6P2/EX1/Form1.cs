using System.Drawing;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowInvoice()
        {
            AddShirtsize(7);
            AddShirtSize2(5);
            AddShirtSize3(2);

        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            AddShirtSize3(2);
        }


        private void btnMedium_Click(object sender, EventArgs e)
        {

            AddShirtSize2(5);

        }
        private decimal AddShirtsize(int size)
        {
            decimal Tax = Convert.ToDecimal(.08);
            int Large = 7;
            decimal Price = Convert.ToDecimal(11.99);
            decimal Total = ((Price * Large));
            rTxtBox1.Text = rTxtBox1.Text = $"{Large} @{Price:c} Total Cost: {Total:c}"
           + $"SubTotal {Total} plus Tax rate of .08 amount:{Total * Tax:c}" +
                $"Invoice Total is {Total + (Total * Tax):c} ";
            return Total;
        }
        private decimal AddShirtSize2(int size)
        {
            decimal Tax = Convert.ToDecimal(.08);
            int Medium = 5;
            decimal Price = Convert.ToDecimal(11.99);
            decimal Total = ((Price * Medium));
            rTxtBox1.Text = $"{Medium} @{Price} Total Cost: {Total:c}"
           + $"SubTotal {Total} plus Tax rate of .08 amount:{Total * Tax:c}" +
                $"Invoice Total is {Total + (Total * Tax):c} ";
            return Total;

        }
        private decimal AddShirtSize3(int size)
        {
            decimal Tax = Convert.ToDecimal(.08);
            int small = 2;
            decimal Price = Convert.ToDecimal(9.99);
            decimal Total = ((Price * small));
            rTxtBox1.Text = rTxtBox1.Text = $"{small} @{Price} Total Cost: {Total:c}"
           + $"SubTotal {Total} plus Tax rate of .08 amount:{Total * Tax:c}" +
                $"Invoice Total is {Total + (Total * Tax):c} ";
            return Total;
        }
        private void btnLarge_Click(object sender, EventArgs e)
        {
            AddShirtsize(7);
        }
        private void ClearOrder()
        {
            rTxtBox1.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            decimal Total = 176.97m;
            decimal Tax = Convert.ToDecimal(1.08);
            rTxtBox1.Text = $"The Total for all three deals is {(AddShirtsize(1) + AddShirtSize2(2) + AddShirtSize3(5)) * Tax:c}" +
                $" **********{AddShirtsize(1)}+{AddShirtSize2(2)}+{AddShirtSize3(3):c}";

        }
    }
}
