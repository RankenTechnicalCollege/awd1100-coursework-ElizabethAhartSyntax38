namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        txtBox1.Focus();
                        break;
                    }
                case Keys.Down:
                    {
                        txtBox5.Focus();

                        break;
                    }
                case Keys.Left:
                    {
                        txtBox7.Focus();

                        break;
                    }
                case Keys.Right:
                    {
                        txtBox3.Focus();

                        break;
                    }

            }
        }

        private void TextboxClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Yellow;
        }

        private void txtFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightGray;

        }
    }
}
