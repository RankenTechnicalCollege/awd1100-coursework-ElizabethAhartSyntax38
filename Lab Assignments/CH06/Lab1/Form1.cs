using System.Windows.Forms.Design;

namespace Lab1
{

    public partial class Lab1 : Form
    {




        public Lab1()
        {

            InitializeComponent();
        }

        //im stupid i started this  lab1 with a mere if statement . and it worked!!!!! by making two arrays alike i could pop out the 
        //text in doubles and generate the right method ,i also used a return to do the if statement , the lab says no return!. Im stupid lol , u cant use random feature on if statements must use a loop to Random. if else in not a loop.
        //The do while loop is a great choice i was able to Do/(display) something WhILE Variables Boolean.
        private void GenerateFortune()
        {
            string[] FortuneCookie = new string[] {"Birthdays are like friends.The more you have the better.","Your smile is a treasure to all who knows you.",
        "You never hesitate to tackle the most difficult problems.","The most obvious solution is not always the best.","If you want the rainbow You will have to tolerate the Rain.",
        "The earlyBird gets the worm but the second mouse gets the cheese.","From listening come wisdom and from speaking repentance.",
        "A smile is your personal welcome mat."};
            // string[] FortuneCookie2 = new string[] {"Birthdats are like friends.The more you have the better.","Your smile is a treasure to all who knows you.",
            // "You never hesitate to tackle the most difficult problems.","The most obvious solution is not always the best.","If you want the rainbow You will have to tolerate the Rain.",
            // "The earlyBird gets the worm but the second mouse gets the cheese.","From listening come wisdom and from speaking repentance.",
            // "A smile is your personal welcome mat."};

            Random rnd = new Random();
            int fortune1Indext = 0;
            int fortune2Indext = 0;

            do
            {
                fortune2Indext = rnd.Next(FortuneCookie.Length);
                fortune1Indext = rnd.Next(FortuneCookie.Length);




            } while (fortune1Indext == fortune2Indext);


            rTxtBox.Text = $"{FortuneCookie[fortune1Indext]}\n" + $"{FortuneCookie[fortune2Indext]}";



        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }

        private void rTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

        
        
         
        
   

        



            
            

            
               
        

        
            
             
            
        
    

