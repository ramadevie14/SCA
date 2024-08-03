using System;
using System.Linq;
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

        public string GetEmployeeData()
        {
			return "okay";
        }

        public bool CheckIfCountryExist(string countryCode)
        {
			return _scadbcontext.Countries.Any(x => x.CountryCode == countryCode);


        }

        public int GetCountryId(string countryCode)
        {
			try
			{
				var country= _scadbcontext.Countries.FirstOrDefault(x => x.CountryCode == countryCode);
				if (country != null)
					return country.CountryId;
				else
					throw new Exception("Country Id does not exist");
			}
			catch(Exception ex)
			{
				throw ex;
			}
        }
    }
}

