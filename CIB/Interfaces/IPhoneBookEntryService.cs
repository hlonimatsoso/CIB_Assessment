using CIB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CIB.Interfaces
{
    public interface IPhoneBookEntryService
    {
        Task<List<PhoneBookEntry>> GetAllPhoneBookEntryiesAsync();

        Task AddPhoneBookEntryAsync(PhoneBookEntry entry);

        Task UpdatePhoneBookEntryAsync(int id, PhoneBookEntry entry);

        Task<PhoneBook> GetPhoneBookEntryAsync(int id);

        Task DeletePhoneBookEntryAsync(int id);
    }
}
