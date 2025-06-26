using System.Collections.Immutable;

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
            
          txtBoxPhrase.Text=UnsortedWords.ToString();
            Array.Sort(UnsortedWords);
            lblDisplay.Text=UnsortedWords[0];
           
               
            }
        private void btnSort_Click(object sender, EventArgs e)
        {
             SortWords([]);
        }


        } 

        
        }
    

