namespace LAB4
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
//for .Tolower to work properly i had to lowercase the movie names in the array . some movie titles have same word in the title 
//so i had to only lower case one of any like words corresponding in movie titles ,now search engine will find mor movies listed in array
        private void btbSubmit_Click(object sender, EventArgs e)
        {

            bool foundArtist = false;
            string userInput = textBox1.Text.ToLower();


            string[
                ] Movies = new string[]{"matilda 1996 theatrical rob dahl's novel","willyWonka johnny depp 1964 Movie",
            "james and The giant peach animation 1996 roal Dahl","2024 piano lesson samuel L jackson as doaker","scarFace 1983 movie rated R",
            "2008 film pineapple express buddy stoner action Comedy by david Gordon","1995 jumanji american adventure & Joe Johnson",
            "B.A.P.S 1997 American Female Buddy Comedy starring robert Townsend and Halle Berry","johnson Family Vacation 04/04 by christopher Erskin",
            "Film scary 2 American parody film By keenan Ivory waynes"};
            for (int i = 0; i < Movies.Length; i++)
            {
                if (Movies[i].Contains(userInput.ToLower()) == true && foundArtist == false)
                {
                    richTextBox1.Text = $"{Movies[i]}";
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
   
    
