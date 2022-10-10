using ContactManagement.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.Persistence.Interfaces
{
    public interface IContactRepository
    {
        public Task<bool> CreateContact(Contact contact);
        public Contact GetContactById(int id);

        public List<Contact> GetAllContacts();

        public Task<bool> DeleteContact(Contact contact);

        public Task<bool> UpdateContact(Contact contact);
    }
}
