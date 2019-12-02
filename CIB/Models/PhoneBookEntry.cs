using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CIB.Models
{
    public class PhoneBookEntry
    {
        public int PhoneBookEntryID { get; set; }
        [Required]
        public int Numuber { get; set; }
        [Required]
        public PhoneBook PhoneBook { get; set; }
    }
}
