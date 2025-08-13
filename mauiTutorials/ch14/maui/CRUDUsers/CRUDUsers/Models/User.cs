using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDUsers.Models
{
public class User //used by EF to Create a Table in The Db context
    {
        public int UserId { get; set; } //primary Key column
        public required string Name { get; set; } //required name column// User is a Domain Model//Link context file

    }


    //user u1 = new User {Id=1,Name="john Doe}; //example of creating a User instance

}
