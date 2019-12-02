using CIB.Interfaces;
using CIB.PhoneBookData;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIB.PhoneBookBlazorApp
{
    public static class Extensions
    {
        public static void RunMigration(this IApplicationBuilder builder)
        {
            var repo = builder.ApplicationServices.GetService(typeof(IPhoneBookRepo)) as PhoneBookSqlRepo;
            repo.RunMigration();
        }
    }
}
