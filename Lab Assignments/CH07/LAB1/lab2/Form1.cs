namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            short ItemNumber = Convert.ToSByte(txtItemNumber.Text);
            byte Quantity = Convert.ToByte(txtQuantity.Text);
            byte EstimatedDelivery = Convert.ToByte(txtDeliveryDays.Text);


            if (ItemNumber > 100 && ItemNumber < 1000 && Quantity > 0 && Quantity < 13 && (EstimatedDelivery > 0 && EstimatedDelivery < 31))
                {

                    Order MyOrder = new Order(ItemNumber, Quantity, EstimatedDelivery);
                    lblDisplay.Text = $"OrderValid";

                }
                else
                {
                    lblDisplay.Text = $" Order NOT Found";
                }

            }
        }
    }


