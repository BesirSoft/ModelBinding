using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public class Customers
    {


        public int CustomerId { get; set; }
        public string FirsNamae { get; set; }
        public string LastName { get; set; }
      
        public  DateTime BirthDate { get; set; }
        public Adress Adress  { get; set; }
        public Role Role { get; set; }




    }

public class Adress
{


        public string Line1  { get; set; }
        public string Line2 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


    }


    public enum Role {

        Admin,
        User,
        Meber
    


    }




}
