using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            User male = new User();
            User female = new User();

            string firstname = male.firstname;
            string lastname = male.lastname;

            string myFirstName = female.firstname = "Deborah";
            string myLastName = female.lastname = "Adeleke";

            Console.WriteLine(firstname + " " + lastname);
            Console.WriteLine(myFirstName + " " + myLastName);
        }
    }
}
