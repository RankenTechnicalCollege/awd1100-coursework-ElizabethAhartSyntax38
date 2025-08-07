using System.Diagnostics.Eventing.Reader;
using System.Drawing.Design;
using System.Security.Cryptography;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random numGenerator = new Random();
            int randomNum = numGenerator.Next(0, 5);
            POKECARD.Sort();

        }
        List<NormalCard> POKECARD = new List<NormalCard>(10);
        NormalCard[] PokeCardValue = new NormalCard[10];
        ShinyCard[] PokeStrong = new ShinyCard[10];
        private void pcBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Random numGenerator = new Random();
                int randomNum = numGenerator.Next(0,25);


                if (randomNum == 0 || randomNum == 1)
                {
                    Name = lblCharmander1.Text;
                    Font = lblCharmander1.Font;
                    BackColor = pcBox1.BackColor;
                    ForeColor = pcBox1.ForeColor;
                    Image Image = pcBox1.Image;
                    pcBox1.Visible = true;
                    lblCharmander1.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox1.Image, 1));
                    lblDisplay.Text = $"{POKECARD}";
                    break;


                }
                else if(randomNum == 2 || randomNum == 3)
                {
                    Name = lblFloragato2.Text;
                    Font = lblFloragato2.Font;
                    BackColor = pcBox2.BackColor;
                    Image Image = pcBox2.Image;
                    pcBox2.Visible = true;
                    lblFloragato2.Visible = true;
                    POKECARD.Add(new NormalCard(lblFloragato2.Text, pcBox2.Image, 2));
                    lblDisplay.Text += $"{POKECARD}";


                    break;
                }
                else if (randomNum == 4 || randomNum == 5)
                {
                    Name = lblJolten3.Text;
                    Font = lblJolten3.Font;
                    BackColor = pcBox3.BackColor;
                    Image Image = pcBox3.Image;
                    pcBox3.Visible = true;
                    lblJolten3.Visible = true;
                    POKECARD.Add(new NormalCard(lblJolten3.Text, pcBox3.Image, 3));
                    lblDisplay.Text += $"{POKECARD}";


                    break;

                }
                else if (randomNum == 6 || randomNum == 7)

                {
                    Name = lblIron4.Text;
                    Font = lblIron4.Font;
                    BackColor = pcBox4.BackColor;
                    Image Image = pcBox4.Image;
                    pcBox4.Visible = true;
                    lblIron4.Visible = true;
                    POKECARD.Add(new NormalCard(lblIron4.Text, pcBox4.Image, 4));
                    lblDisplay.Text += $"{POKECARD}";

                    break;
                }
                else if (randomNum == 8 || randomNum == 9)
                {
                    Name = lblCharzard5.Text;
                    Font = lblCharzard5.Font;
                    BackColor = pcBox5.BackColor;
                    Image Image = pcBox5.Image;

                    pcBox5.Visible = true;
                    lblCharzard5.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharzard5.Text, pcBox5.Image, 5));
                    lblDisplay.Text += $"{POKECARD}";
                    break;

                }
                else if (randomNum == 10 || randomNum == 11)
                {
                    Name = lblEEVEE6.Text;
                    Font = lblEEVEE6.Font;
                    BackColor = pcBox6.BackColor;
                    Image Image = pcBox6.Image;
                    pcBox6.Visible = true;
                    lblEEVEE6.Visible = true;
                    POKECARD.Add(new NormalCard(lblEEVEE6.Text, pcBox6.Image, 6));
                    break;

                }
                else if (randomNum == 11 || randomNum == 12)
                {
                    Name = lblEspeon7.Text;
                    Font = lblEspeon7.Font;
                    BackColor = pcBox7.BackColor;
                    Image Image = pcBox7.Image;
                    pcBox7.Visible = true;
                    lblEspeon7.Visible = true;
                    POKECARD.Add(new NormalCard(lblEspeon7.Text, pcBox7.Image, 10));
                    break;
                }
                else if (randomNum == 13 || randomNum == 14)
                {
                    Name = lblGyrados8.Text;
                    Font = lblGyrados8.Font;
                    BackColor = pcBox8.BackColor;
                    Image Image = pcBox5.Image;

                    pcBox8.Visible = true;
                    lblGyrados8.Visible = true;
                    POKECARD.Add(new NormalCard(lblGyrados8.Text, pcBox8.Image, 10));
                    break;

                } else if (randomNum == 15 || randomNum == 16)
                {
                    Name = lblPichachu9.Text;
                    Font = lblPichachu9.Font;
                    BackColor = pcBox9.BackColor;
                    Image Image = pcBox9.Image;

                    lblDisplay.Text += $"{POKECARD}";

                    pcBox9.Visible = true;
                    lblPichachu9.Visible = true;
                    POKECARD.Add(new NormalCard(lblPichachu9.Text, pcBox9.Image, 9));
                    pcBox10.Visible = true;
                    lblEspeonD.Visible = true;
                    break;



                }
                else if (randomNum == 18 || randomNum == 19)
                {
                    Name = lblEspeonD.Text;
                    Font =lblEspeonD.Font;
                    BackColor = pcBox10.BackColor;
                    Image Image = pcBox10.Image;

                    pcBox10.Visible = true;
                    lblEspeonD.Visible = true;
                    POKECARD.Add(new NormalCard(lblPichachu9.Text, pcBox10.Image, 8));
                   break;
                }

                else
                { 
                    ShinyCard[] Espeon7 = new ShinyCard[1];
                    lblDisplay.Text += $"{new ShinyCard[1]},ESPEON7";

                    ShinyCard[] GYRADOS = new ShinyCard[2];
                    lblDisplay.Text += $"{new ShinyCard[2]},GYRADOS ";

                    pcBox10.Visible = true;
                    lblEspeonD.Visible = true;
                    pcBox1.Visible = true;
                    lblCharmander1.Visible = true;
                    pcBox2.Visible = true;
                    lblFloragato2.Visible = true;
                    pcBox3.Visible = true;
                    lblJolten3.Visible = true;
                    pcBox4.Visible = true;
                    lblIron4.Visible = true;
                    pcBox5.Visible = true;
                    lblCharzard5.Visible = true;
                    pcBox6.Visible = true;
                    lblEEVEE6.Visible = true;
                    pcBox7.Visible = true;
                    lblGyrados8.Visible = true;
                    pcBox8.Visible = true;
                    lblEspeon7.Visible = true;
                    pcBox9.Visible = true;
                    lblPichachu9.Visible = true;
                }
               


                }




            }



        

        private void lblPichachu9_Click(object sender, EventArgs e)
        {

        }
    }
}

  

