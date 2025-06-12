namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
              InitializeComponent();
         
           
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //string[] Game = new string[] { "Player Uknown's Battlefeild Rounds (PUBG)", "Blue hole" };
            //String[] Game2 = new String[] { "League Of Legends", "Riot Game" };
            //string[] Game3 = new String[] { "Call Of Duty Blackopts III", "Activision" };
            //string[] Game4 = new string[] { "BattleFeild 4", "Electronic Arts(EA)" };
            //string[] Game5 = new String[] { "superMario Odyssey", "Nintendo" };
            string[] Publishers = new string[] { "Nintendo", "Electronic Arts(EA)", "Activision", "Riot Game", "Blue hole" };
            string[] Games =new string[] { "Player Uknown's Battlefeild Rounds (PUBG)", "League Of Legends", " Call Of Duty Blackopts III", "BattleFeild 4", "superMario Odyssey" };
            string[] Price = new string[] { "35", "0", "60", "20", "60" };
             string VideoGame = txtBox1.Text.ToLower();


          

            for (int i = 0; i < Games.Length; i++)
                if (Games[i].ToLower().Contains(VideoGame)==true || Publishers[i].ToLower().Contains(VideoGame)==true)
                {
                    lblDisplayName.Text = $"Artist found {Games[i]}";
                    lblPublisher.Text =$"{ Publishers[i] }";
                    lblDisplayPrice.Text =$"{ Price[i] }";
                    break ;
                }
                else
                {
                    lblDisplayName.Text = "Game Not Found";
                    lblDisplayPrice.Text = "Game Not Found";
                    lblDisplayPub.Text = "Game Not Found";
                }
        




                }
    }
}
