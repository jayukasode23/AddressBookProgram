using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class ContactPerson
    {
        List<AddressBook> AddressList;

        public ContactPerson()
        {
            AddressList = new List<AddressBook>();
        }
        public void AddNewContact()
        {
            Console.WriteLine("Fill The Details Given Below: ");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address:");
            string address = Console.ReadLine();
            Console.Write("City:");
            string city = Console.ReadLine();
            Console.Write("State:");
            string state = Console.ReadLine();
            Console.Write("Zip Code: ");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number :");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email Adress : ");

            string emailId = Console.ReadLine();

            AddressBook addressdetails = new AddressBook(firstName, lastName, address, city, state, zipCode, phonenumber, emailId);

            if (AddressList.Contains(addressdetails))
            {
                Console.WriteLine("Details you Enter Is Already Present");
            }
            else
            {
                AddressList.Add(addressdetails);
            }


        }
        public void DisplayContactDetails()
        {
            foreach (AddressBook address in AddressList)
            {
                //Printing Details...
                Console.WriteLine("\nContact Details Are: ");
                Console.WriteLine("Name: {0} {1}", address.firstName, address.lastName);
                Console.WriteLine("Address: {0} {1} {2}", address.address, address.city, address.state);
                Console.WriteLine("Zip Code: {0}", address.zipCode);
                Console.WriteLine("Phone Number: {0}", address.phoneNumber);
                Console.WriteLine("Email Id : {0}", address.emailId);

            }
        }



    }
}
