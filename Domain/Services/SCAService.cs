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

        public string CreateEmployee(EmployeeDTO employeedto)
        {
            try
            {
                var employee = new Employee();
                employee.EmployeeName = employeedto.EmployeeName;
                employee.EmployeeNumber = employeedto.EmployeeNumber;
                employee.ContactNo = employeedto.ContactNo;
                employee.StoreId = _scarepository.GetStoreId(employeedto.StoreNumber);
                _scarepository.CreateEmployee(employee);
                return "Successfullly created employee profile";
            }
            catch(Exception ex)
            {
                return "Unable to create employee" + ex.Message.ToString();
            }

        }

        public List<EmployeeDTO> GetEmployeeData(int storenumber)
        {

            try
            {

                var result = _scarepository.GetEmployeeData(storenumber);
                List<EmployeeDTO> employeeList = new List<EmployeeDTO>();
                foreach (var employee in result)
                {
                    var employeeDto = new EmployeeDTO();
                    employeeDto.EmployeeName = employee.EmployeeName;
                    employeeDto.EmployeeNumber = employee.EmployeeNumber;
                    employeeDto.ContactNo = employee.ContactNo;
                    employeeDto.StoreNumber = employee.Store.StoreNumber;
                    employeeList.Add(employeeDto);
                }

                return employeeList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

