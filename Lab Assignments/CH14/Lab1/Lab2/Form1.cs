namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Photo currentPhoto;
        Color color;
        Material material;
        Style style;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float photoWidth = float.Parse(txtWidth.Text);
            float photoHeight = float.Parse(txtHeight.Text);
            if (radioFrameUn.Checked)
            {
                currentPhoto = new Photo(photoWidth, photoHeight);

            }
            else if (radioFrameMatt.Checked)
            {
                grpColor.Visible = true;
                color = radioBlack.Checked ? Color.BLACK : radioRed.Checked ? Color.RED : radioGreen.Checked ? Color.GREEN : radioBlue.Checked ? Color.BLUE : radioWhite.Checked ? Color.WHITE : Color.BLACK;

                currentPhoto = new Matted(photoWidth, photoHeight, color);
            }
            else if (RADIOFRAMFRAME.Checked)
            {
                grpMaterial.Visible = true;
                grpStyle.Visible = true;
                style = radioStyVintage.Checked ? Style.SIMPLE : radioStyMod.Checked ? Style.MODERN : radioStyAntique.Checked ? Style.ANTIQUE : radioStyVintage.Checked ? Style.VINTAGE : radioStyELectic.Checked ? Style.ELECTRIC : Style.SIMPLE;
                material = radioMatPine.Checked ? Material.PINE : radioMatOak.Checked ? Material.OAK : radioMatSteel.Checked ? Material.STEEL : radioMatGold.Checked ? Material.Gold : Material.PINE;

                currentPhoto = new Framed(photoWidth, photoHeight, material, style);


            }


            lblDisplay.Text = currentPhoto.ToString();
        }

        private void radioFrameMatt_CheckedChanged(object sender, EventArgs e)
        {
            grpColor.Visible = true;
            grpStyle.Visible = false;
            grpMaterial.Visible = false;
           
        }

        private void RADIOFRAMFRAME_CheckedChanged(object sender, EventArgs e)
        {
            grpMaterial.Visible = true;
            grpStyle.Visible = true;
            grpColor.Visible = false;
           
        }

        private void radioFrameUn_CheckedChanged(object sender, EventArgs e)
        {
            grpMaterial.Visible= false;
            grpColor.Visible= false;
            grpStyle.Visible= false;
           
        }
    }
}
