using CIB.Interfaces;
using CIB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIB.PhoneBookData
{
    public class PhoneBookSqlRepo : IPhoneBookRepo
    {
        PhoneBookDBContext _dbContext;

        public PhoneBookSqlRepo(PhoneBookDBContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext", "PhoneBookSqlRepo error: 'dbContext' is null");

            _dbContext = dbContext;
        }
        public async Task AddPhoneBook(PhoneBook phoneBook)
        {
            await _dbContext.AddAsync<PhoneBook>(phoneBook);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePhoneBook(int id)
        {
            await Task.Run(() =>
             {
                 PhoneBook x = GetPhoneBook(id).GetAwaiter().GetResult();
                 _dbContext.Remove<PhoneBook>(x);
                 _dbContext.SaveChangesAsync();
             });
        }

        public async Task UpdatePhoneBook(int id, PhoneBook phoneBook)
        {
            await Task.Run(() =>
            {
                _dbContext.Update<PhoneBook>(phoneBook);
                _dbContext.SaveChangesAsync();
            });
        }

        public async Task<List<PhoneBook>> GetAllPhoneBooksAsync()
        {
            return await _dbContext.PhoneBooks.Include(x => x.Entries).ToListAsync();
        }

        public async Task<PhoneBook> GetPhoneBook(int id)
        {
            return await _dbContext.PhoneBooks.FindAsync(id);
        }

        public void RunMigration()
        {
            try
            {
                _dbContext.Database.Migrate();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error running migration: {ex.Message}", ex);
            }
        }

        public async Task Add<T>(T obj) where T : class
        {
            await _dbContext.AddAsync<T>(obj);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<PhoneBookEntry>> GetAllPhoneBookEntriesAsync()
        {
            return await _dbContext.PhoneBookEntries.ToListAsync();
        }
    }
}
