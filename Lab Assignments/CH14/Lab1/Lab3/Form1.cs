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

        }

        private void pcBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 1000; i++)
            {
                Random numGenerator = new Random();
                int randomNum = numGenerator.Next(0,100);

                if (randomNum ==0)
                {
                    pcBox1.Visible = true;
                    lblCharmander1.Visible = true;
                    break;
                  
                }
                else if (randomNum==1)
                {
                    pcBox2.Visible = true;
                    lblFloragato2.Visible = true;
                    break;
                }
                else if (randomNum == 2)
                {
                    pcBox3.Visible = true;
                    lblJolten3.Visible = true;
                    break;
                }
                else if (randomNum == 3)
                {
                    pcbox4.Visible = true;
                    lblIron4.Visible = true;
                    break;
                }
                else if (randomNum ==4)
                {
                    pcBox5.Visible = true;
                    lblCharzard5.Visible = true;
                    break;
                }
                else if (randomNum == 5)
                {
                    pcBox6.Visible = true;
                    lblEEVEE6.Visible=true;
                    break;
                }
                else if (randomNum == 6)
                {
                    pcBox7.Visible = false;
                    lblEspeon7.Visible = true;
                    break;
                }
                else if (randomNum == 7)
                {
                    pcBox8.Visible = true;
                    lblGyrados8.Visible = true;
                    break;
                }
                else if (randomNum == 8)
                {
                    pcBox9.Visible = true;
                    lblPichachu9.Visible = true;
                    break;

                }
                else if (randomNum == 9)
                {
                    pcbox10.Visible = true;
                    lblESpeon10.Visible = true;
                    break;

                }
                else
                {
                    pcbox10.Visible = false;
                    pcBox1.Visible = false;
                    pcBox2.Visible = false;
                    pcBox3.Visible = false;
                    pcbox4.Visible = false;
                    pcBox5.Visible = false;
                    pcBox6.Visible = false;
                    pcBox7.Visible = false;
                    pcBox8.Visible = false;
                    pcBox9.Visible = false;
                    pcbox10.Visible = false;
                }



            }
        }
    }
}
