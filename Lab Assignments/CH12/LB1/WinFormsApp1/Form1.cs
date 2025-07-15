using LB3;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ChampionNames = new string[] { "Ruckus", "Makoa", "Drogoz", "Tyra", "Grover", "Evie" };
        string[] LeftMouse = new string[] { "Miniguns", "Cannon", "Rocket", " Launcher", "Auto Rifle", "Throwing Axe", "Ice Staff" };
        Champion_Type[] TYPE = new Champion_Type[] { Champion_Type.FRONT_LINE, Champion_Type.FRONT_LINE, Champion_Type.DAMAGE, Champion_Type.DAMAGE, Champion_Type.SUPPORT, Champion_Type.FLANK };
        string[] RightMouse = new string[] { "Missile Launcher", "Dredge Anchor", "Fire Spit", "Nade Launcher", "Crippling Throw", "Ice Block" };
        string[] Q = new string[] { "Emitter", "Shell Shield", "Salvo", "Fire Bomb", "Blossom", "Blink" };
        string[] F = new string[] { "Advance", "Shell Spin", "Thrust", "Hunter's Mark", "Vine", "Soar" };

        string[] E = new string[]{"Hexa Fire","Ancient Rage","Dragon Punch","CrossFire","WhirlWind","Ice Storm"};
    

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string UserInput = txtSearch.Text;
            for (int i = 0; i < ChampionNames.Length; i++)
            {
                if (UserInput.ToLower().Contains(ChampionNames[i].ToLower()))
                {
                    rchDisplay.Text = ChampionNames[i];

                    rchDisplay.Text += TYPE[i]+"\n";
                    rchDisplay.Text += "****_________________***";
                    rchDisplay.Text+= RightMouse[i]+ "\n";
                    rchDisplay.Text += LeftMouse[i] + "\n";
                    rchDisplay.Text += Q[i]+ "\n";
                    rchDisplay.Text += "****_________________***";
                    rchDisplay.Text += F[i] + "\n";
                    rchDisplay.Text += E[i] + "\n";
                   
                    break;
                }
                else
                {
                    rchDisplay.Text = $"Error Error Please Enter a Name to View Like(e.g){ChampionNames[0]},{ChampionNames[1]},{ChampionNames[2]},{ChampionNames[3]},{ChampionNames[4]},{ChampionNames[5]}";
                }
                txtSearch.Clear();
                txtSearch.Focus();
            }
           
                    

                
                
                

                
        }
    }
}
