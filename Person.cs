using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UC5_UC10_
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string EmailId { get; set; }

        internal static void Add(string? name, List<Person> person1)
        {
            throw new NotImplementedException();
        }
    }
}
