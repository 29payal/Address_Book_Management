using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program! ");
            AddressBookCreate addressBook = new AddressBookCreate();
            EditContact newAddressBook = new EditContact();
            Contact newcontact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.FirstName = Console.ReadLine();
                        newcontact.LastName = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.City = Console.ReadLine();
                        newcontact.State = Console.ReadLine();
                        newcontact.Zip = Console.ReadLine();
                        newcontact.PhoneNumber = Console.ReadLine();
                        newcontact.Email = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.FirstName = Console.ReadLine();
                        newcontact.LastName = Console.ReadLine();
                        newcontact.Address = Console.ReadLine();
                        newcontact.City = Console.ReadLine();
                        newcontact.State = Console.ReadLine();
                        newcontact.Zip = Console.ReadLine();
                        newcontact.PhoneNumber = Console.ReadLine();
                        newcontact.Email = Console.ReadLine();
                        newAddressBook.AddContact(newcontact);
                        newAddressBook.Display();
                        break;
                    case 3:
                        newAddressBook.Editexistingcontact();
                        newAddressBook.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }


}