using CIB.Interfaces;
using CIB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIB.PhoneBookBlazorApp.Data.Services
{
    public class PhoneBookEntryService : IPhoneBookEntryService
    {
        IPhoneBookRepo _repo;

        public PhoneBookEntryService(IPhoneBookRepo repo)
        {
            _repo = repo;
        }


        public async Task<List<PhoneBookEntry>> GetAllPhoneBookEntryiesAsync()
        {
            return await _repo.GetAllPhoneBookEntriesAsync();
        }

        public async Task AddPhoneBookEntryAsync(PhoneBookEntry entry)
        {
             await _repo.Add<PhoneBookEntry>(entry);

        }

        public Task UpdatePhoneBookEntryAsync(int id, PhoneBookEntry entry)
        {
            throw new NotImplementedException();
        }

        public Task<PhoneBook> GetPhoneBookEntryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeletePhoneBookEntryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
