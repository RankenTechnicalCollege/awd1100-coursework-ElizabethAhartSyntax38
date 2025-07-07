using System.Net;
using System.Web;

namespace EX2
{
    public partial class btnScan : Form
    {
        public btnScan()
        {
            InitializeComponent();
        }
        private string ScanIPAddress(string IPAddress)
        {
            txtIPAddress.Text = IPAddress;
            return txtIPAddress.Text;

        }
        private void ShowComputer(string ComputerName)
        {
            string userInput = txtIPAddress.Text;
            string[] ComputerName1 = new string[3] { "My-Desktop", "google-public-dns-a", "ranken.edu" };
            for (int i = 0; i < ComputerName1.Length; i++)
            {
                if (userInput.Contains(ComputerName1[i]))
                {
                     lblDisplay.Text=$"{ComputerName1[i]}";
                   
                    break;
                }
                    
            }
        }
        private void btnIPADDRESS_Click(object sender, EventArgs e)
        {
            string[] IPAddress = new string[3] { "127.0.0.1","8.8.8.8","47.44.246.80" };
            string[] Services = new string[3] { "20,21,23,25,53,80,123,389, 443", "53", "25, 80, 443" };
            string[] ComputerName = new string[3] { "My-Desktop","google-public-dns-a","ranken.edu" };
            string UserInput = txtIPAddress.Text;
           
            for (int i = 0; i < ComputerName.Length; i++)
            {
                if (UserInput.Contains(IPAddress[i]))
                {
                    groupBox1.Visible = true;
                    lblDisplay.Visible = true;
                    lblDisplay.Text =$" ComputerName[i]\n";
                    lblDisplay.Text += $"{ComputerName[i]}\n";
                    lblDisplay.Text +=$" IPAddress[i]\n";
                    lblDisplay.Text += $"{IPAddress[i]}\n";
                    lblDisplay.Text +=$" Services[i]\n";
                    lblDisplay.Text += $"{Services[i]}\n";
                   
                    break;

                }
                else
                {
                    lblDisplay.Text = $"COMPUTER cTYPE not Found\n";
                    txtIPAddress.Clear();
                }
            }

        }
    }
}
