namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double CheckDiscountCode(string code)
        {
            txtDiscountCode.Text = code;
            int i = 0;
            string[] Discount = new string[] { "8264", "5679", "6483" };
            double[] DiscountPrice = new double[] { .30, .20, .10 };
            for (int j = 0; i < Discount.Length; i++)
            {
                if (Discount[i].Contains(code))
                {
                    lblDisplayDiscount.Text = $"{DiscountPrice[i]:p}";
                    break;
                } else
                {
                    lblDisplayDiscount.Text = "INVALID DISCOUNT CODE!";
                }

            }
            return (DiscountPrice[i]);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal Tax = Convert.ToDecimal(.7);
            int quantity = Convert.ToInt32(txtQuan.Text);
            decimal subtotal = Convert.ToDecimal((quantity *13.75))* Tax;


            CheckDiscountCode(txtDiscountCode.Text);
            for (int i = 0; i < quantity; i++)
            {
                if (quantity > 0)
                {
                    rTxtBox1.Text = $"Your SubTotal is {quantity * 13.75:c}\n" + $"Your Balance Due is {subtotal + (subtotal * Tax):c}" + $"{quantity} @ 13.75 each Plus .7% tax";
                }
            }



        }
        private float ShowInvoice(int quantity, float discountPercent)
        {
            double Quantity = Convert.ToDouble(txtQuan.Text);
            decimal price = 13.75m;
            string Discount = txtDiscountCode.Text;
            double[] DiscountPrice = new double[] { .30, .20, .10 };
            

                    return discountPercent;
                }
            }
        }
    

