using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Store
    {
        public Store()
        {
        }
        [Key]
        public int Storeid { get; set; }
        public int StoreNumber { get; set; }
        public string StoreName { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}

