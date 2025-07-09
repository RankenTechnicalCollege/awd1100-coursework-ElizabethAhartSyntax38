using System.Web;

namespace Lab1
{
    public partial class Form1 : Form
    {
        List<FlashCard> myDefinitions = new List<FlashCard>()
        {
        new FlashCard("VARIABLE","A VARIABLE is a named memory location","trending Safety O.sha year 08"),
        new FlashCard("JERSEY","JERSEY:A WEARABLE UNIFORM IN THE ATLETIC FEILD with Breathable allowance","Usually A-Top year 72 for Shorts"),
        new FlashCard("HAND","THE PART OF THE BODY connected to the wrist with fingers attached","American History Medicine B.C"),
        new FlashCard("INTEGRITY","THE QUALITY OF BEING HONEST and having strong moral principles; moral uprightness:","a gentleman of complete integrity"),
        new FlashCard("INNOVATION","A NEW METHOD, idea, product,the action or process of innovating etc.:","innovation is crucial to the continuing"),
        };







        int foundIndex = 0;
        //string[] FlashCards = new string[5] { "Variable", "JERSEY", "Hand", "Integrity", "Innovation" };
        //string[] FlashCards2 = new string[5] { "A variable is a named memory Location", "A wearable uniform in the Athletic field with Breathable allowance", "The Part of the body connected to the wrist with fingers attached", "the quality of being honest and having strong moral principles; moral uprightness:", "a new method, idea, product,the action or process of innovating:" };
        //string[] FlashCard3 = new string[5] { "Trending Safety O.sha year 08", "Usually A-Top year 72 for Shorts", "American History Medicine B.C", "moral uprightness: a gentleman of complete integrity", "innovation is crucial to the continuing" };





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //string[] FlashCards = new string[5] { "Variable", "JERSEY", "Hand", "Integrity", "Innovation" };
            //string[] FlashCards2 = new string[5] { "A variable is a named memory Location", "A wearable uniform in the Athletic field with Breathable allowance", "The Part of the body connected to the wrist with fingers attached", "the quality of being honest and having strong moral principles; moral uprightness:", "a new method, idea, product,the action or process of innovating:" };
            //string[] FlashCard3 = new string[5] { "Trending Safety O.sha year 08", "Usually A-Top year 72 for Shorts", "American History Medicine B.C", "moral uprightness: a gentleman of complete integrity", "innovation is crucial to the continuing" };


            string userSearchValue = txtBoxDefine.Text;

            bool foundFlashCard = false;

            for (int i = 0; i < myDefinitions.Count; i++)
            {



                if (myDefinitions[i].Name.ToLower().Contains(userSearchValue))
                {
                    foundFlashCard = true;
                    lblDisplay2.Visible = false;
                    lblName.Visible = false;
                    lbldefinition.Visible = false;
                    lblyear.Visible = false;
                    txtName.Visible = false;
                    txtDescription.Visible = false;
                    txtYear.Visible = false;
                    lblDisplay.Text = myDefinitions[i].ToString();


                    break;
                }






                else if (foundFlashCard == false)
                {
                    groupBox1.Visible = true;
                    lblDisplay2.Visible = true;
                    txtBoxDefine.Visible = true;
                    txtDescription.Visible = true;
                    txtYear.Visible = true;
                    txtName.Visible = true;
                    lblName.Visible = true;
                    lblName.Visible = true;
                    lbldefinition.Visible = true;
                    lblyear.Visible = true;
                    btnADD.Visible = true;
                    lblUpdateWord.Visible = true;
                    txtUpdateDefine.Visible = true;
                    lblUpdateYear.Visible = true;
                    txtupdateYear.Visible = true;
                    txtUpdateWord.Visible = true;
                    lblUpdateDefine.Visible = true;

                    lblDisplay.Text = "Definition Not Found Do You Want to Add it ?";

                    break;


                }

            }
        }



        private void btnADD_Click(object sender, EventArgs e)

        {


            string flashCardName = txtName.Text;
            string flashCardDescription = txtDescription.Text;
            string flashCardYear = txtYear.Text;
            FlashCard flashCardToAdd = new FlashCard("name", "description", "year");

            lblDisplay2.Text = "Definitions Added!";
            lblDisplay2.Text += $"{flashCardName} is your New Word\n";
            lblDisplay2.Text += $"{flashCardDescription}  is The Definition AND  \n";
            lblDisplay2.Text += $"{flashCardYear} is the Trending  \n";
            txtBoxDefine.Text = flashCardName;

            lblDisplay.Text = $"{flashCardName} ::{flashCardDescription} ::{flashCardYear}";
            groupBox1.Visible = true;
            lblUpdateWord.Visible = true;
            txtUpdateDefine.Visible = true;
            lblUpdateYear.Visible = true;
            txtupdateYear.Visible = true;
            txtUpdateWord.Visible = true;
            lblUpdateDefine.Visible = true;

        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblDisplay2.Text = "";
            myDefinitions[foundIndex].Year = txtupdateYear.Text;
            myDefinitions[foundIndex].Name = txtUpdateWord.Text;
            myDefinitions[foundIndex].Description = txtDescription.Text;
            lblDisplay2.Text += $"WORD UPDATED";
            lblDisplay2.Text += myDefinitions[foundIndex].Name;
            lblDisplay2.Text += myDefinitions[foundIndex].Description;
            lblDisplay2.Text += myDefinitions[foundIndex].Year;
            groupBoxdelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            myDefinitions.RemoveAt(foundIndex);
            lblSure.Text = "Movie Deleted";
        }
    }
}










        

