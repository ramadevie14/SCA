using System;
using Infrastructure.Models;

namespace Infrastructure.Interface
{
	public interface ISCARepository
	{
		public int CreateStore(Store store);
		public int CreateCountry(Country country);
		public bool CheckIfCountryExist(string countryCode);
		public int GetCountryId(string countryCode);
		public List<Employee> GetEmployeeData(int employeenumber);
		public int CreateEmployee(Employee employee);
		public int GetStoreId(int StoreNumber);

	}

	
}


