using System;
using Domain.Interface;
using Domain.Models;
using Infrastructure.Interface;
using Infrastructure.Models;

namespace Domain.Services
{
	public class SCAService:ISCAService

	{
        private readonly ISCARepository _scarepository;
		public SCAService(ISCARepository scarepository)
		{
            _scarepository = scarepository;
		}
		
        public string CreateStore(StoreDTO storedto)
        {
            try
            {
                string message="";
               // if (_scarepository.CheckIfCountryExist(storedto.CountryCode))
                {
                    var store = new Store();
                    store.StoreName = storedto.StoreName;
                    store.StoreNumber = storedto.StoreNumber;
                    store.CountryId = _scarepository.GetCountryId(storedto.CountryCode);
                    _scarepository.CreateStore(store);
                    message= "Store created";
                }
                //return "Unable to create store because country does not exist";
                return message;
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string CreateCountry(CountryDTO countrydto)
        {
            try
            {
                var country = new Country();
                country.CountryCode = countrydto.CountryCode;

                country.CountryName = countrydto.CountryName;
                var result = _scarepository.CreateCountry(country);
                
                return "Successfully created country";
                
                  
            }
            catch(Exception ex)
            {
               
                  return "Unable to create country" + ex.Message.ToString();
               
            }
            
        }
    }
}

