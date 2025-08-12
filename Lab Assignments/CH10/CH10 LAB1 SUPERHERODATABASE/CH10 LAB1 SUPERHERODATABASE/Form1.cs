namespace CH10_LAB1_SUPERHERODATABASE
{
    public partial class Form1 : Form
    {
        string[] SuperHero = new string[6] { "NO[SELECT] or Select A SUPERHERO.", "IRON_MAN", "SUPER_MAN", "BAT_MAN", "SPIDER_MAN", "INCREDIBLE_HAWK" };
        string[] Year = new string[6] { "0", "2008 FILM", "2025 DC", " DC Comics Absolute Edition of Batman: Hush (2011)", "comic book Amazing Fantasy #15 (August 1962) ", "2008 American superhero" };
        string[] Description = new string[6] { "0", "Iron Man is a 2008 American superhero film based on the Marvel Comics character of the same name. Produced by Marvel Studios and distributed by Paramount Pictures,", "Superman is a superhero created by writer Jerry Siegel and artist Joe Shuster, first appearing in issue #1 of Action Comics, published in the United States on April 18, 1938.", "is a superhero who appears in American comic books published by DC Comics. Batman was created by artist Bob Kane and writer Bill Finger, and debuted in the 27th issue of the comic book Detective Comics on March 30, 1939. ", "Spider-Man is a superhero in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko, he first appeared in the anthology comic book Amazing Fantasy #15 in the Silver Age of Comic Books.", "The Incredible Hulk is a 2008 American superhero film based on the Marvel Comics character the Hulk. Produced by Marvel Studios and Valhalla Motion Pictures" };
        public Form1()
        {
            InitializeComponent();
            foreach (string SuperHero in SuperHero)
            {
                cmbSuperHero.Items.Add(SuperHero);

            }
            string Super_HERONo = Convert.ToString(cmbSuperHero.SelectedIndex = 0);
            string Super_HeroIRONMAN = Convert.ToString(cmbSuperHero.SelectedIndex = 1);
            string SuperHeroSUPERMAN = Convert.ToString(cmbSuperHero.SelectedIndex = 2);
            string SuperHeroBatMan = Convert.ToString(cmbSuperHero.SelectedIndex = 3);
            string SuperHeroSpiderMan = Convert.ToString(cmbSuperHero.SelectedIndex = 4);
            string SuperHeroINCREDIBLE = Convert.ToString(cmbSuperHero.SelectedIndex = 5);

            Image[] SuperHeroPictures = new Image[5] { pcBoxIron_MAN.Image, pcBoxSUPERMAN.Image, pcBoxBATMAN.Image, pcBoxSPIDERMAN.Image, pcBoxINCREDIBLE.Image };


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbSuperHero.Items.Count; i++)
                if (cmbSuperHero.SelectedIndex == 0)
                {

                    pcBoxBATMAN.Visible = false;
                    pcBoxINCREDIBLE.Visible = false;
                    pcBoxSPIDERMAN.Visible = false;
                    pcBoxIron_MAN.Visible = true;
                    pcBoxINCREDIBLE.Visible = false;
                    lblDisplay.Text = SuperHero[0].ToString() + Year[0].ToString() + Description[0].ToString();
                }
                else if (cmbSuperHero.SelectedIndex == 1)
                {
                    pcBoxIron_MAN.Visible = true;
                    Name = pcBoxIron_MAN.Name;
                    new SUPERHERO(Name, Description[1], Year[1]);
                    lblDisplay.Text = SuperHero[1].ToString() + Year[1].ToString() + Description[1].ToString();
                    pcBoxBATMAN.Visible = false;

                    pcBoxSPIDERMAN.Visible = false;
                    pcBoxINCREDIBLE.Visible = false;
                    pcBoxSUPERMAN.Visible = false;


                }
                else if (cmbSuperHero.SelectedIndex == 2)
                {
                    pcBoxSUPERMAN.Visible = true;
                    Name = pcBoxSUPERMAN.Name;
                    new SUPERHERO(Name, Description[2], Year[2]);
                    lblDisplay.Text = SuperHero[2].ToString() + Year[2].ToString() + Description[2].ToString();
                    pcBoxBATMAN.Visible = false;
                    pcBoxINCREDIBLE.Visible = false;
                    pcBoxSPIDERMAN.Visible = false;
                    pcBoxIron_MAN.Visible = false;

                }
                else if (cmbSuperHero.SelectedIndex == 3)
                {
                    pcBoxBATMAN.Visible = true;
                    Name = pcBoxBATMAN.Name;
                    new SUPERHERO(Name, Description[3], Year[3]);
                    lblDisplay.Text = SuperHero[3].ToString() + Year[3].ToString() + Description[3].ToString();
                    pcBoxSPIDERMAN.Visible = false;
                    pcBoxINCREDIBLE.Visible = false;
                    pcBoxSUPERMAN.Visible = false;
                    pcBoxIron_MAN.Visible = false;

                }
                else if (cmbSuperHero.SelectedIndex == 4)
                {
                    pcBoxSPIDERMAN.Visible = true;
                    Name = pcBoxSPIDERMAN.Name;
                    new SUPERHERO(Name, Description[4], Year[4]);
                    lblDisplay.Text = SuperHero[4].ToString() + Year[4].ToString() + Description[4].ToString();
                    pcBoxBATMAN.Visible = false;
                    pcBoxINCREDIBLE.Visible = false;
                    pcBoxSUPERMAN.Visible = false;
                    pcBoxIron_MAN.Visible = false;

                }
                else if (cmbSuperHero.SelectedIndex == 5)
                {
                    pcBoxINCREDIBLE.Visible = true;
                    Name = pcBoxINCREDIBLE.Name;
                    new SUPERHERO(Name, Description[5], Year[5]);
                    lblDisplay.Text = SuperHero[5].ToString() + Year[5].ToString() + Description[5].ToString();
                    pcBoxBATMAN.Visible = false;
                    pcBoxSPIDERMAN.Visible = false;
                    pcBoxSUPERMAN.Visible = false;
                    pcBoxIron_MAN.Visible = false;

                }
                else
                {
                    lblDisplay.Text = "SEARCH A SUPERHERO to SEE RESULTS";

                }

        }

       
    }
}
