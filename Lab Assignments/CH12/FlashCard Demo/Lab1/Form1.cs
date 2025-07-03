using System.Web;

namespace Lab1
{
    public partial class Form1 : Form
    {
        List<FlashCard> myDefinitions = new List<FlashCard>()
        {

         new FlashCard("VARIABLE","A VARIABLE is a named memory location","trending Safety O.sha year 08"),
         new FlashCard("JERSEY","a wearable uniform in the Athletic field with Breathable allowance","Usually A-Top year 72 for Shorts"),
         new FlashCard("HAND","The Part of the body connected to the wrist with fingers attached","American History Medicine B.C"),
         new FlashCard("INTEGRITY","the quality of being honest and having strong moral principles; moral uprightness:","\"a gentleman of complete integrity\""),
        new FlashCard("INNOVAION","a new method, idea, product,the action or process of innovating:\r\n\" etc.:","innovation is crucial to the continuing"),


         };
        //string[] FlashCards = new string[5] { "Variable", "JERSEY", "Hand", "Integrity", "Innovation" };
        //string[] FlashCards2 = new string[5] { "A variable is a named memory Location", "A wearable uniform in the Athletic field with Breathable allowance", "The Part of the body connected to the wrist with fingers attached", "the quality of being honest and having strong moral principles; moral uprightness:", "a new method, idea, product,the action or process of innovating:" };
        //string[] FlashCard3 = new string[5] { "Trending Safety O.sha year 08", "Usually A-Top year 72 for Shorts", "American History Medicine B.C", "moral uprightness: a gentleman of complete integrity", "innovation is crucial to the continuing" };





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] FlashCards = new string[5] { "Variable", "JERSEY", "Hand", "Integrity", "Innovation" };
            string[] FlashCards2 = new string[5] { "A variable is a named memory Location", "A wearable uniform in the Athletic field with Breathable allowance", "The Part of the body connected to the wrist with fingers attached", "the quality of being honest and having strong moral principles; moral uprightness:", "a new method, idea, product,the action or process of innovating:" };
            string[] FlashCard3 = new string[5] { "Trending Safety O.sha year 08", "Usually A-Top year 72 for Shorts", "American History Medicine B.C", "moral uprightness: a gentleman of complete integrity", "innovation is crucial to the continuing" };


            string userSearchValue = txtBoxDefine.Text;

            bool foundFlashCard = false;
            //for (int i = 0; i < myDefinitions.Count; i++)
            //{
            //    {
            for (int i = 0; i < myDefinitions.Count; i++)
            {



                if (myDefinitions[i].Name.ToLower().Contains(userSearchValue) == true || FlashCards2[i].ToLower().Contains(userSearchValue) == true) 


                {
                   
                    foundFlashCard = true;
                    lblDisplay2.Visible = false;
                    lblName.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    txtName.Visible = false;
                    txtDescription.Visible = false;
                    txtYear.Visible = false;
                    lblDisplay.Text = myDefinitions[i].ToString();
                    lblDisplay2.Visible = foundFlashCard;
                }





                else if (foundFlashCard == false)
                {
                    lblDisplay2.Visible = true;
                    txtBoxDefine.Visible = true;
                    txtDescription.Visible = true;
                    txtYear.Visible = true;
                    txtName.Visible = true;
                    lblName.Visible = true;
                    lblName.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;
                    btnADD.Visible = true;
                    lblDisplay.Text = "Definition Not Found Do You Want to Add it ?";
                    break;


                }
                else if (foundFlashCard == false && txtName.Visible)
                {
                    string UserAdd = txtName.Text;
                    lblDisplay.Text = $" Definition Added {txtName.Text}\n";
                    FlashCard[] AddDefinitions = new FlashCard[20];
                    lblDisplay2.Text += $"{UserAdd}";
                    break;
                }
            }
        }



        private void btnADD_Click(object sender, EventArgs e)

        {
           
            for (int i = 0; i < myDefinitions.Count; i++)
            {

                if (txtName.Text.ToLower() != "")
                {
                    FlashCard[] AddDefinitions = new FlashCard[20];


                    string flashCardName = txtName.Text;
                    string flashCardDescription = txtDescription.Text;
                    string flashCardYear = txtYear.Text;

                    lblDisplay2.Text = "Definitions Added!";
                    lblDisplay2.Text += $"{txtName.Text} is your New Word\n";
                    lblDisplay2.Text += $"{txtDescription.Text}  is The Definition AND  \n";
                    lblDisplay2.Text += $"{txtYear.Text} is the Trending  \n";
                    txtBoxDefine.Text = flashCardName;
                    
                    lblDisplay.Text = $"{flashCardName} ::{flashCardDescription} ::{flashCardYear}";
                    break ;






                }
            }
        }
    

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}





        

