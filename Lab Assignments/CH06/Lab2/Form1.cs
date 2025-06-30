using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SortWords(string[] UnsortedWords)
        {


           
            Array.Sort(UnsortedWords);
           
            foreach (string word in UnsortedWords)
            {
                lblDisplay.Text += word + " "; 
            }


        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            string phrase=txtBoxPhrase.Text;
            string[] UnsortedWords =phrase.Split(' ');
            

            SortWords(UnsortedWords);
            
            
        }


        } 

        
        }
    

