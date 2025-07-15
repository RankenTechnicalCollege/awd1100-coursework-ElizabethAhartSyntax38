namespace LB2
{
    public partial class Form1 : Form
    {

        public Form1()

        {

            InitializeComponent();
        }
        List<Conference> conferences = new List<Conference>();
        int conferenceCount = 0;

        private void btnADD_Click(object sender, EventArgs e)
        {
            Conference newConference = new Conference()
            {
                GroupName = txtGroupName.Text,
                Room = (ROOMS)Convert.ToInt32(txtRoom.Text),
                StartDate = DateTime.Parse(txtStart.Text),
                Attendees = Convert.ToInt32(txtAttendees.Text)
            };
            if (conferenceCount < 20)
            {
                conferences.Add(newConference);
                conferenceCount++;
                lblDisplayGroup.Text = $"{conferenceCount}/20\n ";               
                lblDisplayGroup.Text += $"ROOMS AVAILIABLE";
            }
            else
            {
                MessageBox.Show("All Booked VACANCIES soon!");

            }
            txtGroupName.Clear();
            txtGroupName.Focus();
            txtAttendees.Clear();
            txtRoom.Clear();
            txtStart.Clear();
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblDisplaySearch.Text = " ";
            DateTime BeginingDate= DateTime.Parse(txtBegin.Text);
            DateTime endDate= DateTime.Parse(txtEnd.Text);
            foreach (Conference conference  in conferences)
            {
                if (conference.StartDate >= BeginingDate && conference.StartDate <= endDate)
                {
                    lblDisplaySearch.Text += conference.Display();
                }
        
            }
            
        }
    }
}
