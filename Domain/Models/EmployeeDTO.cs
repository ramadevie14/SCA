using System;
namespace Domain.Models
{
	public class EmployeeDTO
	{
		public EmployeeDTO()
		{
		}
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string ContactNo { get; set; }
		public int StoreNumber { get; set; }
    }
}

