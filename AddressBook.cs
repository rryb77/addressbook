using System;
using System.Collections.Generic;

namespace addressbook
{
    class AddressBook
    {

        public Dictionary<string, Contact> Contacts { get; set; }
        public void AddContact(Contact person)
        {
            try
            {
                Contacts.Add(person.Email, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }

        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>();
        }
    }
}