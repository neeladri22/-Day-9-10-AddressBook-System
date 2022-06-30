using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public String zip;
        public String phoneNumber;
        public String email;

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public string Address { get ; set; }
        public string City { get; set; }
        public string State { get ; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get ; set ; }
        public string Email { get ; set ; }


    }
}
