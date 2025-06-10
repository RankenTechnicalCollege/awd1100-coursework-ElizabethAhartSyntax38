// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Please Enter a test score between (0-100) to sum or 999 to stop.");
int userInput=Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i =0;
int sum1 = 0;
int sum3 = 0;
for (i = 0; i < (10); i++)
     Console.WriteLine("Please enter a test score between (0-100) to sum or 999 to stop.");
          int userInput2 = Convert.ToInt32(Console.ReadLine());
        if (userInput>i && userInput<100) sum++;
while (userInput != 999)
 sum1 = sum1 + userInput2;
    if (userInput > 100)
        Console.WriteLine("Invalid Score ! TRY AGAIN!!");
{
          
    
    
    if (userInput2 >= i && userInput2 <= 100)
    {
        sum1 = sum1 + userInput;
        if (userInput2 > 100)
            Console.WriteLine("Invalid Score ! TRY AGAIN!!");
    }
 Console.WriteLine("Please enter a test score between (0-100) to sum or 999 to stop.");
       int userInput3 = Convert.ToInt32(Console.ReadLine());
    if (userInput3 > i)
        while (userInput3 != 999)
        if (userInput3>100)
Console.WriteLine("Invalid Score ! TRY AGAIN!!");
            
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

        

    



    

    
   

    




