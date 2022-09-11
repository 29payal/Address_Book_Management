using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class DeleteContact
{
    List<Contact> AddressList = new List<Contact>();
    public void AddContact(Contact newcontact)
    {
        AddressList.Add(newcontact);
    }
    public void Editexistingcontact()
    {
        Console.WriteLine("Enter first name of person you want to edit");
        string name = Console.ReadLine();
        foreach (var contact in AddressList)
        {
            if (contact.FirstName == name)
            {
                Console.WriteLine("Enter number : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new firstname");
                        string first = Console.ReadLine();
                        contact.FirstName = first;
                        break;
                    case 2:
                        Console.WriteLine("Enter new lastname");
                        string last = Console.ReadLine();
                        contact.LastName = last;
                        break;
                    case 3:
                        Console.WriteLine("Enter new address");
                        string address = Console.ReadLine();
                        contact.Address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enter new city");
                        string city = Console.ReadLine();
                        contact.City = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter new state");
                        string state = Console.ReadLine();
                        contact.State = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter new zip");
                        string zip = Console.ReadLine();
                        contact.Zip = zip;
                        break;
                    case 7:
                        Console.WriteLine("Enter new phonenumber");
                        string phone = Console.ReadLine();
                        contact.PhoneNumber = phone;
                        break;
                    case 8:
                        Console.WriteLine("Enter new emailid");
                        string email = Console.ReadLine();
                        contact.Email = email;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void Deletecontact()
    {
        Console.WriteLine("Enter first name you want delete");
        string name = Console.ReadLine();
        Contact delete = new Contact();
        foreach (var contact in AddressList)
        {
            if (contact.FirstName == name)
            {
                AddressList.Remove(contact);
                Console.WriteLine(name + " contact is deleted");
                Display();
                break;
            }
        }
    }
    public void Display()
    {
        foreach (var contact in AddressList)
        {
            Console.WriteLine("\nfirstname: " + contact.FirstName + "\nlastname: " + contact.LastName + "\naddress: " + contact.Address + "\ncity: " + contact.City + "\nstate: " + contact.State + "\nzip: " + contact.Zip + "\nphoneno: " + contact.PhoneNumber + "\nemail: " + contact.Email);
        }
    }
}
}