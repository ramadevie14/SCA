using System;
using System.Collections.Generic;
using System.Linq;
using Application.Exceptions;
using Infrastructure.Interface;
using Infrastructure.Models;

namespace Infrastructure.Repositories
{
	public class SCARepository:ISCARepository
	{
		private readonly SCADBContext _scadbcontext; 
		public SCARepository(SCADBContext scadbcontext)
		{
			_scadbcontext = scadbcontext;
		}
		public int CreateStore(Store store)
		{
			_scadbcontext.Stores.Add(store);
            var result=_scadbcontext.SaveChanges();
			return result;
            
		}
		public int CreateCountry(Country country)
		{
			try
			{
				_scadbcontext.Countries.Add(country);
				return _scadbcontext.SaveChanges();
			}
			catch (Exception ex)
			{
				throw;
			}
		}

        public List<Employee> GetEmployeeData(int storenumber)
        {
			

				var result = _scadbcontext.Stores.FirstOrDefault(s => s.StoreNumber == storenumber);
				if (result != null)
				{
					var employeedata = _scadbcontext.Employees.Where(e => e.StoreId == result.Storeid).ToList();

					return employeedata;
				}
				else
				{
					var myException = new NotFoundException("Store not found" );
					throw myException;
				}
			
			
        }

        public bool CheckIfCountryExist(string countryCode)
        {
			return _scadbcontext.Countries.Any(x => x.CountryCode == countryCode);


        }

        public int GetCountryId(string countryCode)
        {
				var country= _scadbcontext.Countries.FirstOrDefault(x => x.CountryCode == countryCode);
				if (country != null)
					return country.CountryId;
				else
					throw new NotFoundException("Country Id does not exist");
			
		
        }

        public int CreateEmployee(Employee employee)
        {
			_scadbcontext.Employees.Add(employee);
			var result=_scadbcontext.SaveChanges();
			return result;
        }

        

        public int GetStoreId(int StoreNumber)
        {
			
				var store = _scadbcontext.Stores.FirstOrDefault(x => x.StoreNumber == StoreNumber);
				if (store != null)
					return store.Storeid;
				else
					throw new NotFoundException( "store does not exist");
		

        }


    }
}

