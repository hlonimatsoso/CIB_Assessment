using CIB.Interfaces;
using CIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIB.PhoneBookBlazorApp.Data.Services
{
    public class PhoneBookService : IPhoneBookService
    {
        IPhoneBookRepo _repo;

        public PhoneBookService(IPhoneBookRepo repo)
        {
            _repo = repo;
        }

        public async Task AddPhoneBookAsync(PhoneBook phoneBook)
        {
           await _repo.AddPhoneBook(phoneBook);
        }

        public async Task DeletePhoneBookAsync(int id)
        {
           await _repo.DeletePhoneBook(id);
        }

        public async Task UpdatePhoneBookAsync(int id, PhoneBook phoneBook)
        {
           await _repo.UpdatePhoneBook(id, phoneBook);
        }

        public async Task<List<PhoneBook>> GetAllPhoneBooksAsync()
        {
            return await _repo.GetAllPhoneBooksAsync();
        }

        public async Task<PhoneBook> GetPhoneBookAsync(int id)
        {
           return await _repo.GetPhoneBook(id);
        }
    }
}
