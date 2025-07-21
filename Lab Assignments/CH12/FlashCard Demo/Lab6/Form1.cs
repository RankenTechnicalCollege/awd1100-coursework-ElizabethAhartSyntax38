namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string Display()
        {
           
           
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);
            int area = Convert.ToInt32(length * width);
            int boxes = (area / 12) + 2;
            return $"{Name} {width*length}needs this many {boxes}";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] Rooms = new string[20];
            int width =Convert.ToInt32( txtWidth.Text);
            int length=Convert.ToInt32(txtLength.Text);
            int area = Convert.ToInt32(length*width);
            string name=txtName.Text;
            int boxes=(area/12)+2;
           lblDisplay.Text = $"your area of {area} is this many {boxes} Boxes";
           lblDisplay.Text+= Display() ;


        }
    }
}
