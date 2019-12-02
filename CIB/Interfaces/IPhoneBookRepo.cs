using CIB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CIB.Interfaces
{
    public interface IPhoneBookRepo
    {
        Task<List<PhoneBook>> GetAllPhoneBooksAsync();

        Task AddPhoneBook(PhoneBook phoneBook);

        Task UpdatePhoneBook(int id, PhoneBook phoneBook);

        Task<PhoneBook> GetPhoneBook(int id);

        Task DeletePhoneBook(int id);

        void RunMigration();

        Task Add<T>(T obj) where T : class;

        Task<List<PhoneBookEntry>> GetAllPhoneBookEntriesAsync();



    }
}
