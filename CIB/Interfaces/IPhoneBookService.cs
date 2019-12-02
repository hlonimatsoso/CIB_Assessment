using CIB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CIB.Interfaces
{
    public interface IPhoneBookService
    {
        Task<List<PhoneBook>> GetAllPhoneBooksAsync();

        Task AddPhoneBookAsync(PhoneBook phoneBook);

        Task UpdatePhoneBookAsync(int id, PhoneBook phoneBook);

        Task<PhoneBook> GetPhoneBookAsync(int id);

        Task DeletePhoneBookAsync(int id);
    }
}
