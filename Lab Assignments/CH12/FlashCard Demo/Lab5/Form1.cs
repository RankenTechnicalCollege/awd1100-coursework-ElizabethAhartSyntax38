namespace Lab5
{
    public partial class Form1 : Form
    {
        List<job> jobs = new List<job>();
       
        public Form1()
        {
           
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            string description=txtJobDes.Text;
           double hoursToComplete = Convert.ToDouble(txtHoursToComplete.Text);
            double HourlyRate=Convert.ToDouble(txtHourly.Text);
            job jobToAdd = new job(description,hoursToComplete,HourlyRate,35);
           
            lblCurrentDescription.Text = description;
            lblCurrentHours.Text = hoursToComplete.ToString();
            lblCurrentRate.Text = HourlyRate.ToString();
            Double TotalCost=hoursToComplete*HourlyRate;
            lblDisplayTotal.Text=$"{TotalCost:c}".ToString();
           
            
          


           

        }
    }
}
