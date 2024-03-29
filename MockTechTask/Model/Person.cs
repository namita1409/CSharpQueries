﻿using FileHelpers;

namespace MockTechTask.Model
{
    [DelimitedRecord(",")]
    public class Person
    {     
        public int Index { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }    
        public string County { get; set; }
        public string Postal { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }

        public string toString() 
        {
            return  "Index = "+Index +"\n"
                    + "First_Name = " + FirstName + "\n "
                    + "Last_Name = "+LastName + "\n "
                    + "Company = "+Company+ "\n "
                    +"Address = "+Address + "\n "
                    +"City"+ City+ "\n "
                    +"County "+ County+ " \n"
                    + "Postal "+Postal+ " \n" 
                    + " Phone1 "+ Phone1 +" \n"
                    + " Phone2 "+Phone2 +"\n"
                    +"Email "+ Email + "\n" 
                    +"Web "+ Web+"\n ";
        }
    }
}

