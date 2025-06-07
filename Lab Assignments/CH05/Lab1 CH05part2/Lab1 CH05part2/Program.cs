// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Please Enter a test score between (0-100) to sum or 999 to stop.");
int userInput=Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (userInput != 999)
{
    if (userInput >= 0 && userInput <= 100)
    {
        sum = sum + userInput;

    }
    if (userInput > 100)
        while (userInput != 999)
        {

            Console.WriteLine("Invalid Score ! TRY AGAIN!!");
            Console.WriteLine("Please enter a test score between (0-100) to sum or 999 to stop.");
            userInput = Convert.ToInt32(Console.ReadLine());
            int userInput2 = userInput;
            int sum3 = 0;
            sum3 = sum3 + userInput;
            Console.WriteLine("Please Enter a score between (0-100");
            int userInput3 = userInput;
            int sum1 = 0;
            sum1 = sum1 + userInput;
        
            Console.WriteLine("Valid Scores are between (0-100)");
            Console.WriteLine($"The average of Test scores is {(sum + sum3 +sum1)/3 }");
            Console.WriteLine($"The sum of the Test scores are {sum+sum1}");

        if (userInput>userInput2 && userInput<userInput3)
            Console.WriteLine($"The highest Test score is {userInput3}");
        else if (userInput > userInput3 && userInput < userInput2)
            Console.WriteLine($"The highest TestScore is {userInput2}");
        else if (userInput3 > userInput2 && userInput3 < userInput)
            Console.WriteLine($"THE HIGHEST SCORE IS {userInput}");
            Console.WriteLine("Thanks for using my program");
          
            
         
        } 

        }

    



    

    
   

    




