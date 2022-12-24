using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC5_UC10_
{
    internal class Contact
    {
        List<Person> person1 = new List<Person>();
        Dictionary<string, List<Person>> person2 = new Dictionary<string, List<Person>>();
        public void addcontact()
        {
            Person person = new Person();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNo = Console.ReadLine();
            Console.Write("Enter Address : ");
            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();
            Console.Write("Enter city : ");
            person.City = Console.ReadLine();
            Console.Write("Enter pinCode : ");
            person.ZipCode = Console.ReadLine();
            Console.Write("Enter EmailId : ");
            person.EmailId = Console.ReadLine();

            //UC7
            if (person1.Count > 0)
            {
                foreach (var contact in person1)
                {
                    if (contact.FirstName.Equals(person.FirstName) && contact.LastName.Equals(person.LastName))
                    {
                        Console.WriteLine("*************");
                        Console.WriteLine(person.FirstName + " is already Present in the AddressBook");
                    }
                    else
                        person1.Add(person);
                }
            }
            else
                person1.Add(person);
            Console.ReadLine();
        }
        //UC3-Edit person Details
        public void EditContact()
        {
            Console.WriteLine("Enter the 1st Name");
            string FirstName = Console.ReadLine();
            Person person = new Person();
            person1.Equals(person);
            Console.WriteLine("Enter a new Name");
            Console.ReadLine();
            Console.WriteLine("Contacts are successfully Edited");
            Console.ReadLine();
        }
        //UC4-Delete contact Details
        public void RemoveDetails()
        {
            Console.WriteLine("Enter the first Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last Name");
            string LastName = Console.ReadLine();
            Person person = new Person();
            person1.Remove(person);
            Console.WriteLine("Contacts are successfully Deleted");
            Console.ReadLine();
        }
        // UC5
        public void CreateDict()
        {
            Console.WriteLine("Enter a name here");
            string name = Console.ReadLine();
            Person.Add(name, person1);
            person1 = new List<Person>();
        }

        internal void displayDetails()
        {
            throw new NotImplementedException();
        }

        //UC6
        public void DisplayDict()
        {
            foreach (var data in person2)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName);
                    Console.WriteLine(contact.LastName);
                    Console.WriteLine(contact.Address);
                    Console.WriteLine(contact.PhoneNo);
                    Console.WriteLine(contact.ZipCode);
                    Console.WriteLine(contact.EmailId);
                }
            }
        }
    }
}
