using System;
using Domain.Models;
using Infrastructure.Models;

namespace Domain.Interface
{
	public interface ISCAService
	{
		public string CreateStore(StoreDTO store);
		public string CreateCountry(CountryDTO country);
		public string CreateEmployee(EmployeeDTO employee);
		public List<EmployeeDTO> GetEmployeeData(int storenumber);
	}
}

