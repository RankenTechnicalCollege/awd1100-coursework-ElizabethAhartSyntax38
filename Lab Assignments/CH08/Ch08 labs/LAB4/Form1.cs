namespace LAB4
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void btbSubmit_Click(object sender, EventArgs e)
        {

            bool foundArtist = false;
            string userInput = textBox1.Text.ToLower();


            string[] Movies = new string[]{"Matilda 1996 Theatrical Rob Dahl's Novel","WillyWonka Johnny Depp 1964 Movie",
            "James and The Giant Peach Animation 1996 Roal Dahl","2024 Piano Lesson Samuel L Jackson as Doaker","ScarFace 1983 movie Rated R",
            "2008 Film Pineapple Express Buddy Stoner Action Comedy by David Gordon","1995 Jumanji American Adventure & Joe johnson",
            "B.A.P.S 1997 American Female Buddy Comedy Starring Robert Townsend and Halle Berry","Johnson Family Vacation 04/04 by Christopher Erskin",
            "film American parody film By Keenan Ivory Waynes"};
            for (int i = 0; i < Movies.Length; i++)
            {
                if (Movies[i].Contains(userInput.ToLower())==true||foundArtist==false)
                {
                    richTextBox1.Text =$"{Movies[i]}";
                    break;
                }
                else
                {
                    richTextBox1.Text = "Movie NOT FOUND!!";
                } 

            }
        }
    }
}
    
