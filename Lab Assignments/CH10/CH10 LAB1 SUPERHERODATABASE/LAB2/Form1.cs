namespace LAB2
{
    public partial class Form1 : Form
    {
        string[] Jobs = new string[5] { "MAINTENANCE", "COMPUTER SCEIENCE", "ACCOUNTANCY", "ADMINISTRATION", "PROFFESSIONAL DANCE" };
        string[] DESCRIPTION = new string[5] { "Additional InformationPay:\n $22.00/hour\nJob Number25126446 Job\n CategoryEngineering \n& Facilities LocationMarriott \nSt. Louis Grand\n, 800 Washington Avenue Saint\n Louis Missouri United States 63101VIEW \nON MAP\n", "The field of computer science\n offers a wide range of lucrative career opportunities.\n With the rapid advancements\n in technology\n the demand for skilled professionals in this domain is on the rise.\n", "The Accounting Specialist will be responsible \nfor supporting key financial operations\n, with a focus on accounts payable,\n accounts receivable, billing, \nand general ledger support. \nThis individual will also assist with \npayment processing, respond to vendor and\n client inquiries, and maintain accurate financial records. \nThe ideal candidate is detail-oriented, well-versed in QuickBooks Desktop,\n and comfortable working independently and as part of a team.\n", "The Office Administrator will manage all \noperations of the assigned office (s)\n, including human resources, financial planning and controls\n, marketing and event planning, facilities, information …\n", "How To Become a Professional Dancer | Backstage\r\nMay 22, 2023 · To get your dance career off on the right foot,\n we’ve compiled an in-depth guide to becoming a professional \ndancer—including how to find dance …Author: \nVictoria Dombroski\n" };
        public Form1()
        {

            InitializeComponent();
            foreach (string JOB in Jobs)
            {
                cmbJOBDATA.Items.Add(JOB);
            }
            string Maintenance = Convert.ToString(cmbJOBDATA.SelectedIndex = 0).ToString();
            string COMPUTERSCIENCE = Convert.ToString(cmbJOBDATA.SelectedIndex = 1).ToString();
            string ACCOUNTANCY = Convert.ToString(cmbJOBDATA.SelectedIndex = 2).ToString();
            string ADMINISTRATION = Convert.ToString(cmbJOBDATA.SelectedIndex = 3).ToString();
            string PROFESSIONAL = Convert.ToString(cmbJOBDATA.SelectedIndex = 4).ToString();


        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {


                if (cmbJOBDATA.SelectedIndex == 0)
                {


                    lstSearchRESULT.Items.Add(Jobs[0].ToString() + DESCRIPTION[0].ToString());
                    lstSearchRESULT.Items.Add(SelectionMode.MultiExtended);
                    lblDisplay.Text = DESCRIPTION[0];
                    new JOB(cmbJOBDATA.ToString(), lstSearchRESULT.Text, INDUSTRY.Matenance);
                   


                }
                else if (cmbJOBDATA.SelectedIndex == 1)
                {

                    lstSearchRESULT.Items.Add($"{Jobs[1].ToString()}\n + {DESCRIPTION[1].ToString()}\n");
                    lstSearchRESULT.Items.Add(SelectionMode.MultiExtended);
                    lblDisplay.Text = DESCRIPTION[1];
                    new JOB(cmbJOBDATA.ToString(), lstSearchRESULT.Text, INDUSTRY.computerScience);



                }
                else if (cmbJOBDATA.SelectedIndex == 2)
                {

                    lstSearchRESULT.Items.Add($"{Jobs[2].ToString()}\n { DESCRIPTION[2].ToString()}\n");
                    lstSearchRESULT.Items.Add(SelectionMode.MultiExtended);
                    lblDisplay.Text = DESCRIPTION[2];
                    new JOB(cmbJOBDATA.ToString(), lstSearchRESULT.Text, INDUSTRY.Accountancy);



                }
                else if (cmbJOBDATA.SelectedIndex == 3)
                {

                    lstSearchRESULT.Items.Add($"{Jobs[3].ToString()}\n +{ DESCRIPTION[3].ToString()}\n");
                    lstSearchRESULT.Items.Add(SelectionMode.MultiExtended);
                    lblDisplay.Text =DESCRIPTION[3];
                    new JOB(cmbJOBDATA.ToString(), lstSearchRESULT.Text, INDUSTRY.Administration);


                }
                else if (cmbJOBDATA.SelectedIndex == 4)
                {

                    lstSearchRESULT.Items.Add($"{Jobs[4].ToString()}\n +{ DESCRIPTION[4].ToString()}\n");
                    lstSearchRESULT.Items.Add(SelectionMode.MultiExtended);
                    lblDisplay.Text = DESCRIPTION[4];
                    new JOB(cmbJOBDATA.ToString(), lstSearchRESULT.Text, INDUSTRY.Professional);


                }

                else
                {
                    lstSearchRESULT.Items.Add("SEARCH A JOB to SEE RESULTS");
                    lblDisplay.Text=$"{lstSearchRESULT.Text}";

                }

            }
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}
