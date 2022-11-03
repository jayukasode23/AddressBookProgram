using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class AddMultipleContact
    {
        // Here, Creating New List To Add Data Information.
        List<AddressBook> AddressList;

        public AddMultipleContact()
        {
            AddressList = new List<AddressBook>();
        }
        //Here,Adding New Contact By Using Method.
        public void AddMultipleNewContact()
        {
            //Here,Taking Details (Contact Details)From User To Add In Address Book.
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

            //Creating Instance And Passing Parameter.
            AddressBook addressdetails = new AddressBook(firstName, lastName, address, city, state, zipCode, phonenumber, emailId);

            //Here,Defining Logic With The Help Of  If Else To Check Contact Details Present Or Not, If Not Then Add Contact Details.
            int CheckDetails = 0;
            if (AddressList.Count > 0) //Count The Address Present In Address Book.
            {
                foreach (AddressBook Address in AddressList)
                {


                    if (Address.firstName == firstName && Address.lastName == lastName)
                    {
                        CheckDetails = 1;//Check Present Or Not If Present Then Assign Check Details Is 1.
                        Console.WriteLine("Name: {0} {1}", Address.firstName, Address.lastName);

                    }
                }
            }

            //Here Use If Else Loop For Checking  Details Present Or Not,If Present Going To If Block And If Not Then Goes To Else Block.
            if (CheckDetails == 1)
            {
                Console.WriteLine("You Enter The Name  Is Already Present In Address Book");
            }
            else
            {
                AddressList.Add(addressdetails);//Here ,Add Details In Address Book.
            }
        }
        //Here,Define Method To Display Contact Details After Adding New Contact By User.
        public void DisplayContactDetails()
        {
            if (AddressList.Count > 0)
            {
                //
                foreach (AddressBook Address in AddressList)
                {
                    //Printing Details...
                    Console.WriteLine("\nContact Details Are: ");
                    Console.WriteLine("Name: {0} {1}", Address.firstName, Address.lastName);
                    Console.WriteLine("Address: {0} {1} {2}", Address.address, Address.city, Address.state);
                    Console.WriteLine("Zip Code: {0}", Address.zipCode);
                    Console.WriteLine("Phone Number: {0}", Address.phoneNumber);
                    Console.WriteLine("Email Id : {0}", Address.emailId);

                }
            }
        }
    }
}
    