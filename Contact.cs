﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC5_UC10_
{
    internal class Contact
    {
        List<Person> person1 = new List<Person>();
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
    }
}
