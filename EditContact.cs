using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    public class EditContact
    {
        List<AddressBook> AddressList;

        public EditContact()
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
                Console.WriteLine("**Details you Enter Is Already Present**");
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
        public void EditContactDetails()
        {
            Console.WriteLine("**Enter The First Name For Edit The Contact**");
            string firstName = Console.ReadLine();
            foreach (AddressBook address in AddressList)
            {
                if (address.firstName == firstName)
                {
                    //This Is The User Input For Which Field Want To Edit
                    Console.WriteLine("1. First Name:");
                    Console.WriteLine("2.Last Name");
                    Console.WriteLine("3.Address");
                    Console.WriteLine("4.City");
                    Console.WriteLine("5.State");
                    Console.WriteLine("6.ZipCode");
                    Console.WriteLine("7.Phone Number");
                    Console.WriteLine("8.Email Address");
                    Console.WriteLine("Enter The Field  For Edit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    //Using Switch Case Edit The Fields Choose By User.
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("New First Name:");
                            string newfirstName = Console.ReadLine();
                            address.firstName = newfirstName;
                            break;
                        case 2:
                            Console.WriteLine("New Last Name:");
                            string newlastName = Console.ReadLine();
                            address.lastName = newlastName;
                            break;
                        case 3:
                            Console.WriteLine("New Address:");
                            string newaddress = Console.ReadLine();
                            address.address = newaddress;
                            break;
                        case 4:
                            Console.WriteLine("New City Name:");
                            string newcity = Console.ReadLine();
                            address.city = newcity;
                            break;
                        case 5:
                            Console.WriteLine("New State Name:");
                            string newstate = Console.ReadLine();
                            address.state = newstate;
                            break;
                        case 6:
                            Console.WriteLine(" New ZipCode:");
                            int newzipcode = Convert.ToInt32(Console.ReadLine());
                            address.zipCode = newzipcode;
                            break;
                        case 7:
                            Console.WriteLine("New Phone Number:");
                            long newphoneNumber = Convert.ToInt64(Console.ReadLine());
                            address.phoneNumber = newphoneNumber;
                            break;
                        case 8:
                            Console.WriteLine("New EmailId:");
                            string newemailId = Console.ReadLine();
                            address.emailId = newemailId;
                            break;

                        default:
                            Console.WriteLine("Oops!Please Enter Correct Choice");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Enter Input Is Not Available In Adress Book");
                }
            }
        }
    }
}
