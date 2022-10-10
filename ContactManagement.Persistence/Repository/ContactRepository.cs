using ContactManagement.Persistence.Context;
using ContactManagement.Persistence.Interfaces;
using ContactManagement.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.Persistence.Repository
{
    public class ContactRepository : IContactRepository
    {

        private readonly ApplicationDbContext _dbContext;
        public ContactRepository(ApplicationDbContext ctx)
        {
            _dbContext = ctx;
        }

        public Task<bool> CreateContact(Contact contact)
        {
            try
            {
                _dbContext.Add(contact);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return Task.FromResult(false);
            }
        }

        public Task<bool> DeleteContact(Contact contact)
        {
            try
            {
                _dbContext.Remove(contact);
                _dbContext.SaveChanges();
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return Task.FromResult(false);
            }
        }

        public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = _dbContext.Contact.ToList();
            return contacts;
        }

        public Contact GetContactById(int id)
        {
            try
            {
                return _dbContext.Contact.FirstOrDefault(c => c.ContactId == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public Task<bool> UpdateContact(Contact contact)
        {
            try
            {
                _dbContext.Entry(contact).State = EntityState.Modified;
                _dbContext.SaveChangesAsync();
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return Task.FromResult(false);
            }
        }
    }
}
