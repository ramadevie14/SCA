using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class IPSales
    {
        public IPSales()
        {
        }
        [Key]
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public int StoreId { get; set; }
        public decimal RetailPrice { get; set; }
        public string CountryCode { get; set; }
        public int StoreNumber { get; set; }

    }
}

