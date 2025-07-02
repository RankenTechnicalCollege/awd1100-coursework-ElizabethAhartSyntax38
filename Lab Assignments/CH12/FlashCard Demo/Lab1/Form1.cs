namespace Lab1
{
    public partial class Form1 : Form
    {
        List<FlashCard> myDefinitions = new List<FlashCard>()
        {
         new FlashCard("Variable","A variable is a named memory Location","Trending Safety O.sha year 08"),
         new FlashCard("Jersey","A wearable uniform in the Athletic field with Breathable allowance","Usually A-Top year 72 for Shorts"),
         new FlashCard("Hand","The Part of the body connected to the wrist with fingers attached","American History Medicine B.C"),
         new FlashCard("Integrity","the quality of being honest and having strong moral principles; moral uprightness:","\"a gentleman of complete integrity\""),
        new FlashCard("Innovation","a new method, idea, product,the action or process of innovating:\r\n\" etc.:","innovation is crucial to the continuing")

         };
        int foundIndex = -1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           lblDisplay2.Visible = true;
            txtBoxDefine.Visible = true;
            txtDescription.Visible = true;
            txtYear.Visible = true;
            txtName.Visible = true;
            lblName.Visible = true;
           lblName.Visible=true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            btnADD.Visible = true;
            string userSearchValue = txtBoxDefine.Text;
           
            bool foundFlashCard = false;
            for (int i = 0; i < myDefinitions.Count; i++)
            {
                {
                    if (myDefinitions[i].Name.ToLower().Contains(userSearchValue))
                    {
                        foundFlashCard = true;
                        lblDisplay.Text = myDefinitions[i].ToString();
              
                       
                    }
                    else if (foundFlashCard == false)
                    {
                        lblDisplay.Text = "Definition Not Found Do You Want to Add it ?";
                         break;
                 
                       

                        
                     
                    }
                        
            }
                }
        }


        private void btnADD_Click(object sender, EventArgs e)

        {
            for (int i = 0; i < myDefinitions.Count; i++)
            {

                if (txtName.Text.ToLower() != "") 
                    {
                         FlashCard flashCardToAdd =new (Name, txtDescription.Text, txtYear.Text);
                    string flashCardName = txtName.Text;
                        string flashCardDescription = txtDescription.Text;
                        string flashCardYear=txtYear.Text;

                    lblDisplay2.Text = "Definitions Added!";
                     lblDisplay2.Text= $"{txtName} is your New Word\n" +$"{txtDescription}is The Definition AND\n" +$"{txtYear} is the Trending\n";
                    break;
                     
                
                       
               
                        
                        

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



        

