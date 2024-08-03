
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string ContactNo { get; set; }
        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }



    }
}

