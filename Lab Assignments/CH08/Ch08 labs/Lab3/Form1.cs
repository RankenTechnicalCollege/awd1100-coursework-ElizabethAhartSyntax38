
namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        private float GetPrice()
        {
            float[] Price = new float[] {35, 0, 60, 20, 60 };
            string VideoGame = txtBox1.Text.ToLower();
            return Price[04];
        }
        private string GetGame()
        {
            string VideoGame = txtBox1.Text.ToLower();
            string[] Games = new string[] { "Player Uknown's Battlefeild Rounds (PUBG)", "League Of Legends", " Call Of Duty Blackopts III", "BattleFeild 4", "superMario Odyssey" };
            return Games[04];

        }
        private string GetPublisher()
        {
            string VideoGame = txtBox1.Text.ToLower();
            string[] Publishers = new string[] { "Nintendo", "Electronic Arts(EA)", "Activision", "Riot Game", "Blue hole" };
            return VideoGame;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string[] Publishers = new string[] { "Nintendo", "Electronic Arts(EA)", "Activision", "Riot Game", "Blue hole" };
            string[] Games = new string[] { "Player Uknown's Battlefeild Rounds (PUBG)", "League Of Legends", " Call Of Duty Blackopts III", "BattleFeild 4", "superMario Odyssey" };
            string[] Price = new string[] { "35", "0", "60", "20", "60" };
            string VideoGame = txtBox1.Text.ToLower();




            for (int i = 0; i < Games.Length; i++)
                if (Games[i].ToLower().Contains(VideoGame) == true || Publishers[i].ToLower().Contains(VideoGame) == true)
                {
                    lblDisplayName.Text = $"Artist found {Games[i]}";
                    lblDisplayPub.Text = $"{Publishers[i]}";
                    lblDisplayPrice.Text = $"{Price[i]}";
                    break;
                }
                else
                {
                    lblDisplayName.Text = "Game Not Found";
                    lblDisplayPrice.Text = "Game Not Found";
                    lblDisplayPub.Text = "Game Not Found";
                }





        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
