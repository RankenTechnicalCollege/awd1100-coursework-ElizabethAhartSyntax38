using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Web;

namespace Lab1_2_3
{
    public partial class Form1 : Form
    {

       
        




        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
            bool Award = true;
            bool Deny = false;
            int AdmissionScore =Convert.ToInt32( textBox2.Text);
            decimal GPA=Convert.ToDecimal(textBox1.Text);
            string[]StudentAward = new string[] {"Accept","Deny"};

            for (int i = 0;i<StudentAward.Length;i++)
            {
                if (AdmissionScore >= 80 || GPA >= 3)
                {
                    lblDisplay.Text = StudentAward[0];
                  
                }
                else
                {
                    lblDisplay.Text = StudentAward[1];
                    

                    
                   
                }
             

            }
               
          
           


        }
            

        }
    }

          
        
              

            
            
            

        

       
    
    

