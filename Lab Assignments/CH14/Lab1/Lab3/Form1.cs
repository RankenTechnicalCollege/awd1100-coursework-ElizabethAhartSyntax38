using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random numGenerator = new Random();
            int randomNum = numGenerator.Next(1,10);
            POKECARD.Sort();

        }
        List<NormalCard> POKECARD = new List<NormalCard>(10);
        private void pcBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 1000; i++)
            {
                Random numGenerator = new Random();
                int randomNum = numGenerator.Next(0,100);


                if (randomNum == 0)
                {
                    pcBox1.Visible = true;
                    lblCharmander1.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox1.Image, 1));
                    break;

                }
                else if (randomNum == 1)
                {
                    pcBox2.Visible = true;
                    lblFloragato2.Visible = true;
                    POKECARD.Add(new NormalCard(lblFloragato2.Text, pcBox2.Image, 2));
                    break;
                }
                else if (randomNum == 2)
                {
                    pcBox3.Visible = true;
                    lblJolten3.Visible = true;
                    POKECARD.Add(new NormalCard(lblJolten3.Text, pcBox3.Image, 3));
                    break;
                }
                else if (randomNum == 3)
                {
                    pcBox4.Visible = true;
                    lblIron4.Visible = true;
                    POKECARD.Add(new NormalCard(lblIron4.Text, pcBox4.Image, 4));
                    break;
                }
                else if (randomNum == 4)
                {
                    pcBox5.Visible = true;
                    lblCharzard5.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox5.Image, 5));
                    break;
                }
                else if (randomNum == 5)
                {
                    pcBox6.Visible = true;
                    lblEEVEE6.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox6.Image, 6));
                    break;
                }
                else if (randomNum == 6)
                {
                    pcBox7.Visible = false;
                    lblEspeon7.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox7.Image, 10));
                    break;
                }
                else if (randomNum == 7)
                {
                    pcBox8.Visible = true;
                    lblGyrados8.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox8.Image, 10));
                    break;
                }
                else if (randomNum == 8)
                {
                    pcBox9.Visible = true;
                    lblPichachu9.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox9.Image, 9));
                    break;

                }
                else if (randomNum == 9)
                {
                    pcBox10.Visible = true;
                    lblESpeon10.Visible = true;
                    POKECARD.Add(new NormalCard(lblCharmander1.Text, pcBox10.Image, 8));
                    break;

                }
                else
                {
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
                    pcBox10.Visible = false;
                    POKECARD.Sort();
                   
                    
                }
                        

                    
                    
                }



            }
        }
    }

