using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
   public static class ContactRespository
    {
      public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact {Name="Person1", Email="person1email"},
            new Contact {Name="Person2", Email="person2email"},
            new Contact { Name = "Person3", Email = "person3email" },
            new Contact { Name = "Person4", Email = "person4email" },
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById (int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactID == contactId);
        }


    }
}
