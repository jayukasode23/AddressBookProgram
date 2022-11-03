using Address;
using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing Welcome Message
            Console.WriteLine("-------Welcome To Address Book System Program---------");
            Console.WriteLine("------------------------------------------------------");
            int choice;

            {
                Console.WriteLine("Press 0 For Exit");
                Console.WriteLine("1.Enter Contact Is Present In Adress Book");
                Console.WriteLine("2.Add New Contact To Address Book");
                Console.WriteLine("3.Edit Contact Present In Adress Book");
                Console.WriteLine("4.Delete Contact Using Users First Name");
                Console.WriteLine("5.Add Multiple Contact To Address Book");
                Console.WriteLine("---------------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Output For Create Contact In Address Book");
                        //creating Instance Object
                        AddressBook objDetails = new AddressBook("Jayshree", "Kasode", "Makhmalabad Naka", "Nasik",
                                                                     "Maharashtra", 422004,9988776655, "jayukasode2398@gmail.com");
                        //calling method
                        objDetails.DisplayContactDettails();
                        break;
                    case 2:
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Output For Create Add New Contact In Address Book");
                        ContactPerson Objaddnewcontact = new ContactPerson();
                        Objaddnewcontact.AddNewContact();
                        Objaddnewcontact.DisplayContactDetails();

                        break;

                    case 3:
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Output For Edit Contact From Address Book");
                        //Here ,Creating Instance And Call The Method To Add New Contact.
                        EditContact Objeditcontact = new EditContact();
                        Objeditcontact.AddNewContact();
                        Objeditcontact.DisplayContactDetails();
                        Objeditcontact.EditContactDetails();
                        //Here ,Edit Contact Details  And Call The Method For Editing Contact.
                        Console.WriteLine("Edit Contact Using First Name. 1:Y/N");
                        Console.Write("Enter Your Choice: ");
                        string choice3 = Console.ReadLine();
                        if (choice3 == "Y")
                        {
                            Objeditcontact.EditContactDetails();
                            Objeditcontact.DisplayContactDetails();

                        }
                        break;
                    case 4:
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Output For Delete  Contact From Address Book");
                        //Here, Creating Instance For Call The Method To Edit And Delete Contact Details. 
                        DeleteContact objDeleteAddress = new DeleteContact();
                        objDeleteAddress.AddNewContact();
                        objDeleteAddress.DisplayContactDetails();

                        //Here,Asking To Edit Contact If Yes then Proceed.
                        Console.WriteLine("Enter Contact Using First Name: Y/N");
                        Console.Write("Enter Your Choice:");
                        string choice4_1 = Console.ReadLine();
                        if (choice4_1 == "Y")
                        {
                            objDeleteAddress.EditContactDetails();
                            objDeleteAddress.DisplayContactDetails();
                        }
                        //Asking To Delete The Contact Details If Y Then Proceed.
                        Console.WriteLine("Delete Contact Using First Name: Y/N");
                        Console.Write("Enter Your Choice: ");
                        string choice4_2 = Console.ReadLine();
                        if (choice4_2 == "Y")
                        {
                            objDeleteAddress.DeleteContactDetails();
                        }
                        else
                        {
                            objDeleteAddress.DisplayContactDetails();
                        }
                        break;
                    case 5:
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Output For AddMultiple  Contact In Address Book");
                        // Here,Creating Instance For Call The Methods To Edit The And Delete Contact details.
                        AddMultipleContact objMultipleContact = new AddMultipleContact();
                    Add:
                        Console.WriteLine("Enter Details : Y/N");
                        Console.Write("Enter Your Choice:");
                        string choice5_1 = Console.ReadLine();
                        if (choice5_1 == "Y")
                        {
                            objMultipleContact.AddMultipleNewContact();
                            objMultipleContact.DisplayContactDetails();
                            goto Add;

                        }
                        break;
                }
            }
        }
    }
}