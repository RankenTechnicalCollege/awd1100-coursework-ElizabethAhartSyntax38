using System.Collections.Immutable;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace Book_Store_Inventory_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchAuthor(string Book)
        {
            string AuthorSearch = txtAuthor.Text;
            string[] KeyWords = new string[] {"The story of eccentric millionaire Jay Gatsby and his Pursuit of  his lost love.","A fictional story about the 1812 French Invasion of Russia.",
                "The story of a Sailor's Relentless hunt for a White Whale.","A Shakesperean tragedy about a young man coming home from college after the murder of his father.","A Comedic story of love and life in Old England." };
            string[] ISBN = new string[] { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
            string[] Name = new string[] { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Predjudice" };
            string[] Author = new string[] { "F. Scott Fitgeral", "Leo Tolsby", "Herman Melville", "William Shakespeare", "Jane Auslen" };
            for (int i = 0; i < Author.Length; i++)
                if (Author[i].ToLower().Contains(AuthorSearch))
                {
                    lblDisplayAuthor.Text = $"{Author[i]}";
                    lblDisplayIsbn.Text = $"{ISBN[i]}";
                    lblDisplayDescript.Text = $"{KeyWords[i]}";
                    lblDisplayname.Text=$"{Name[i]}";
                    break;

                }
                else
                {
                    lblDisplayAuthor.Text = "Author Not Found";

                }
        }
        
        private void SearchByIsbn(string Code)
        {
            string IsbnSearch= txtIsbn.Text;
            string[] Author = new string[] { "F. Scott Fitgeral", "Leo Tolsby", "Herman Melville", "William Shakespeare", "Jane Auslen" };
            string[] KeyWords = new string[] {"The story of eccentric millionaire Jay Gatsby and his Pursuit of  his lost love.","A fictional story about the 1812 French Invasion of Russia.",
                "The story of a Sailor's Relentless hunt for a White Whale.","A Shakesperean tragedy about a young man coming home from college after the murder of his father.","A Comedic story of love and life in Old England." };
            string[] Name = new string[] { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Predjudice" };
            string[] ISBN = new string[] { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
            for(int i = 0;i < ISBN.Length; i++)
            {
                if (ISBN[i].Contains(IsbnSearch))
                {
                    lblDisplayIsbn.Text = $"{ISBN}";
                    lblDisplayname.Text =$"{Name[i]}";
                    lblDisplayDescript.Text = $"{KeyWords[i]}";
                    lblDisplayAuthor.Text=$"{Author[i]}";
                    break;
                }
                else
                {
                    lblDisplayIsbn.Text = $"ISBN NOT FOUND";
                }
            }
            
            
        }
        private void SearchByKeyWord(string KeyW)
        {
            string KeywordSearch = txtKeyWord.Text;
            string[] ISBN = new string[] { "978-1847496140", "978-1400079988", "978-1503280786", "978-1973844402", "978-0141439518" };
            string[] Author = new string[] { "F. Scott Fitgeral", "Leo Tolsby", "Herman Melville", "William Shakespeare", "Jane Auslen" };
            string[] Name = new string[] { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Predjudice" };
            string[] KeyWords = new string[] {"The story of eccentric millionaire Jay Gatsby and his Pursuit of  his lost love.","A fictional story about the 1812 French Invasion of Russia.",
                "The story of a Sailor's Relentless hunt for a White Whale.","A Shakesperean tragedy about a young man coming home from college after the murder of his father.","A Comedic story of love and life in Old England." };
            for (int i = 0; i < KeyWords.Length; i++)
            {
                if (KeyWords[i].Contains(KeywordSearch))
                {
                    lblDisplayDescript.Text = $"{KeyWords[i]}";
                    lblDisplayAuthor.Text = $"{Name[i]}";
                    lblDisplayname.Text = $"{Name[i]}";
                    lblDisplayIsbn.Text = $"{ISBN[i]}" ;
                }
                else
                {
                    lblDisplayDescript.Text = "DESCRIPTION NOT FOUND";
                }
                
            }
        }
        private void ShowBook()
        {
            string KeywordSearch = txtKeyWord.Text;
            string[] KeyWords = new string[] {"The story of eccentric millionaire Jay Gatsby and his Pursuit of  his lost love.","A fictional story about the 1812 French Invasion of Russia.",
                "The story of a Sailor's Relentless hunt for a White Whale.","A Shakesperean tragedy about a young man coming home from college after the murder of his father.","A Comedic story of love and life in Old England." };
            string[] Name = new string[] { "The Great Gatsby", "War and Peace", "Moby-Dick", "Hamlet", "Pride and Predjudice" };
            for (int i = 0; i < KeyWords.Length; i++)
            {
                if (KeyWords[i].Contains(KeywordSearch))
                {
                    lblDisplayname.Text = $"{Name[i]}";
                }

            }
        }


        private void btnSearchAuth_Click(object sender, EventArgs e)
        {
            SearchAuthor("gatsby");
            {
               
            }
            txtAuthor.Clear();
           
        }
        



        private void btnSearchIsbn_Click(object sender, EventArgs e)
        {
            SearchByIsbn("gatsby");
            {

            }
            txtIsbn.Clear();
        }

        private void btnSearchKeyWord_Click(object sender, EventArgs e)
        {
            SearchByKeyWord("scott");
            {

            }
            txtKeyWord.Clear();
        }
    }
}

