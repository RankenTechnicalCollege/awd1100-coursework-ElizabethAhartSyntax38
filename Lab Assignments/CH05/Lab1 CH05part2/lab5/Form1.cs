using System.Formats.Nrbf;

namespace lab5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void CountVowel(string Phrase)
        {

            string Phrases = txtBox1.Text;
            Phrases = Phrases.ToLower();
            int vowel = 0;


            for (int i = 0; i < Phrases.Length; i++)
            {
                if ('a' == Phrases[i])
                {
                    vowel++;

                }
                else if ('e' == Phrases[i])
                {
                    vowel++;

                }
                else if ('i' == Phrases[i])
                {
                    vowel++;

                }
                else if ('o' == Phrases[i])
                {
                    vowel++;

                }
                else if ('u' == Phrases[i])
                {
                    vowel++;

                }
            }
            lbl1.Text = $"The number of vowels in your phrase is {vowel}";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            CountVowel((string)txtBox1.Text);
            







            }

        }

    }

        
    

            
       
			

			  
			
            
			
        

        
           

      
    



