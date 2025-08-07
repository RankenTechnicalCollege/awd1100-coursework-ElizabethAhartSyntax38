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
            for (int i = 0; i < 10; i++)
            {
                Random numGenerator = new Random();
                int randomNum = numGenerator.Next(1, 5);


                if (randomNum == 0 || randomNum == 1)
                {
                    pcBox1.Visible = true;
                    lblCharmander1.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox1.Image, 1));
                    lblDisplay.Text = $"{POKECARD[randomNum]}";


                    pcBox2.Visible = true;
                    lblFloragato2.Visible = true;
                    POKECARD.Add(new NormalCard(lblFloragato2.Text, pcBox2.Image, 2));
                    lblDisplay.Text = $"{POKECARD[randomNum]}";


                    pcBox3.Visible = true;
                    lblJolten3.Visible = true;
                    POKECARD.Add(new NormalCard(lblJolten3.Text, pcBox3.Image, 3));
                    lblDisplay.Text = $"{POKECARD[randomNum]}";


                    pcBox4.Visible = true;
                    lblIron4.Visible = true;
                    POKECARD.Add(new NormalCard(lblIron4.Text, pcBox4.Image, 4));
                    lblDisplay.Text = $"{POKECARD[randomNum]}";


                    pcBox10.Visible = true;
                    lblEspeonD.Visible = true;
                    POKECARD.Add(new NormalCard(lblEspeonD.Text, pcBox10.Image, 8));
                    lblDisplay.Text = $"{POKECARD[randomNum]}";


                }
                else if (randomNum == 2 || randomNum == 3)
                {

                    pcBox5.Visible = true;
                    lblCharzard5.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharzard5.Text, pcBox5.Image, 5));


                    pcBox6.Visible = true;
                    lblEEVEE6.Visible = true;
                    POKECARD.Add(new NormalCard(lblEEVEE6.Text, pcBox6.Image, 6));


                    pcBox8.Visible = true;
                    lblGyrados8.Visible = true;
                    POKECARD.Add(new NormalCard(lblGyrados8.Text, pcBox8.Image, 10));


                    pcBox7.Visible = true;
                    lblEspeon7.Visible = true;
                    POKECARD.Add(new NormalCard(lblEspeon7.Text, pcBox7.Image, 10));


                    lblDisplay.Text += $"{POKECARD}";
                    pcBox9.Visible = true;
                    lblPichachu9.Visible = true;
                    POKECARD.Add(new NormalCard(lblPichachu9.Text, pcBox9.Image, 9));

                    break;
                }

                else if (randomNum == 4)
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
                else if (randomNum == 5)
                {
                  
                    ShinyCard[] ESPEON = new ShinyCard[1];
                    lblDisplay.Text += $"{new ShinyCard[1]},ESPEON7";

                    ShinyCard[] GYRADOS = new ShinyCard[2];
                    lblDisplay.Text += $"{new ShinyCard[2]},GYRADOS";


                    pcBox10.Visible = false;

                    pcBox1.Visible = false;
                    pcBox2.Visible = false;
                    pcBox3.Visible = false;
                    pcBox4.Visible = false;
                    pcBox5.Visible = false;
                    pcBox6.Visible = false;
                    pcBox7.Visible = true;
                    pcBox8.Visible = true;
                    pcBox9.Visible = false;
                    lblEspeonD.Visible = false;
                    lblCharmander1.Visible = false;
                    lblFloragato2.Visible = false;
                    lblJolten3.Visible = false;
                    lblIron4.Visible = false;
                    lblCharzard5.Visible = false;
                    lblEEVEE6.Visible = false;
                    lblEspeon7.Visible = false;
                    lblGyrados8.Visible = false;
                    lblPichachu9.Visible = false;
                    lblEspeonD.Visible = false;



                }




            }



        }

        private void lblPichachu9_Click(object sender, EventArgs e)
        {

        }
    }
}

  

