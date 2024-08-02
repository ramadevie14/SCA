using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Country
    {
        public Country()
        {
        }
        [Key]
        public int CountryId { get; set; }
        public string ContryName { get; set; }
        public string ContryCode { get; set; }


    }
}

