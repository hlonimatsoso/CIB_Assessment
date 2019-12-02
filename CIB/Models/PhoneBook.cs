using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CIB.Models
{
    public class PhoneBook
    {
        public int PhoneBookID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<PhoneBookEntry> Entries { get; set; }
    }
}
