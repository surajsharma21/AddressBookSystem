using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        public List<Contact> ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }
        public void AddContact(Contact contactObj)
        {
            this.ContactList.Add(contactObj);
        }
    }
}
